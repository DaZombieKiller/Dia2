using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Dia2
{
    sealed class ComStream : IStream, IDisposable
    {
        const int STATFLAG_NONAME = 0x1;

        const int STGTY_STREAM = 0x2;

        const int STGM_READ = 0x0;

        const int STGM_WRITE = 0x1;

        const int STGM_READWRITE = 0x2;

        const int STG_E_INVALIDFUNCTION = unchecked((int)0x80030001);

        public Stream Stream { get; }

        public ComStream(Stream stream)
        {
            Stream = stream;
        }

        public void Read(byte[] pv, int cb, IntPtr pcbRead)
        {
            for (int remaining = cb; remaining > 0;)
            {
                int read = Stream.Read(pv, cb - remaining, remaining);

                if (read == 0)
                {
                    Marshal.WriteInt32(pcbRead, cb - remaining);
                    return;
                }

                remaining -= read;
            }

            Marshal.WriteInt32(pcbRead, cb);
        }

        public void Write(byte[] pv, int cb, IntPtr pcbWritten)
        {
            Stream.Write(pv, 0, cb);
            Marshal.WriteInt32(pcbWritten, cb);
        }

        public void Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition)
        {
            Marshal.WriteInt64(plibNewPosition, Stream.Seek(dlibMove, (SeekOrigin)dwOrigin));
        }

        public void SetSize(long libNewSize)
        {
            Stream.SetLength(libNewSize);
        }

        public void Stat(out STATSTG pstatstg, int grfStatFlag)
        {
            pstatstg = new STATSTG { type = STGTY_STREAM };

            if ((grfStatFlag & STATFLAG_NONAME) == 0)
                pstatstg.pwcsName = Stream is FileStream fs ? fs.Name : string.Empty;
            
            if (Stream.CanSeek)
                pstatstg.cbSize = Stream.Length;

            if (Stream.CanRead && Stream.CanWrite)
                pstatstg.grfMode = STGM_READWRITE;
            else if (Stream.CanWrite)
                pstatstg.grfMode = STGM_WRITE;
            else
                pstatstg.grfMode = STGM_READ;
        }

        public void Commit(int grfCommitFlags)
        {
            Stream.Flush();
        }

        public void Dispose()
        {
            Stream.Dispose();
        }

    #pragma warning disable CS8767
        public void Clone(out IStream? ppstm)
    #pragma warning restore CS8767
        {
            ppstm = null;
        }

        public void Revert()
        {
        }

        public void CopyTo(IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten)
        {
            throw new COMException(null, STG_E_INVALIDFUNCTION);
        }

        public void LockRegion(long libOffset, long cb, int dwLockType)
        {
            throw new COMException(null, STG_E_INVALIDFUNCTION);
        }

        public void UnlockRegion(long libOffset, long cb, int dwLockType)
        {
            throw new COMException(null, STG_E_INVALIDFUNCTION);
        }
    }
}
