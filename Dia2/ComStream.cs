using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Dia2
{
    sealed class ComStream : IStream, IDisposable
    {
        public Stream Stream { get; }

        public ComStream(Stream stream)
        {
            if (stream is null)
                throw new ArgumentNullException(nameof(stream));

            Stream = stream;
        }

        public void Read(byte[] pv, int cb, IntPtr pcbRead)
        {
            var read = Stream.Read(pv, 0, cb);

            if (pcbRead != IntPtr.Zero)
            {
                Marshal.WriteInt32(pcbRead, read);
            }
        }

        public void Write(byte[] pv, int cb, IntPtr pcbWritten)
        {
            Stream.Write(pv, 0, cb);

            if (pcbWritten != IntPtr.Zero)
            {
                Marshal.WriteInt32(pcbWritten, cb);
            }
        }

        public void Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition)
        {
            long position = Stream.Seek(dlibMove, (SeekOrigin)dwOrigin);

            if (plibNewPosition != IntPtr.Zero)
            {
                Marshal.WriteInt64(plibNewPosition, position);
            }
        }

        public void SetSize(long libNewSize)
        {
            Stream.SetLength(libNewSize);
        }

        public void Stat(out STATSTG pstatstg, int grfStatFlag)
        {
            var flags = (StatFlags)grfStatFlag;
            pstatstg  = new STATSTG
            {
                type   = (int)StorageType.Stream,
                cbSize = Stream.Length
            };

            if (!flags.HasFlag(StatFlags.NoName) && Stream is FileStream fs)
                pstatstg.pwcsName = fs.Name;

            if (Stream.CanRead && Stream.CanWrite)
                pstatstg.grfMode |= (int)StorageMode.ReadWrite;
            else if (Stream.CanRead)
                pstatstg.grfMode |= (int)StorageMode.Read;
            else if (Stream.CanWrite)
                pstatstg.grfMode |= (int)StorageMode.Write;
            else
                throw new IOException("Current stream object was closed and disposed. Cannot access a closed stream.");
        }

        public void Commit(int grfCommitFlags)
        {
            Stream.Flush();
        }

        public void Dispose()
        {
            Stream.Dispose();
        }

        void IStream.Clone(out IStream ppstm)
        {
            ppstm = null!;
            throw new NotSupportedException();
        }

        void IStream.Revert()
        {
            throw new NotSupportedException();
        }

        void IStream.CopyTo(IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten)
        {
            throw new NotSupportedException();
        }

        void IStream.LockRegion(long libOffset, long cb, int dwLockType)
        {
            Marshal.ThrowExceptionForHR((int)StorageError.InvalidFunction, new IntPtr(-1));
        }

        void IStream.UnlockRegion(long libOffset, long cb, int dwLockType)
        {
            Marshal.ThrowExceptionForHR((int)StorageError.InvalidFunction, new IntPtr(-1));
        }

        [Flags]
        enum StatFlags
        {
            None   = 0,
            NoName = 1 << 0,
            NoOpen = 1 << 1
        }

        [Flags]
        enum StorageMode
        {
            Read      = 0,
            Write     = 1 << 0,
            ReadWrite = 1 << 1
        }

        enum StorageType
        {
            Storage   = 1,
            Stream    = 2,
            LockBytes = 3,
            Property  = 4
        }

        enum StorageError
        {
            InvalidFunction = unchecked((int)0x80030001)
        }
    }
}
