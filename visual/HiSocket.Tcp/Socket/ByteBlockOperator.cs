﻿/***************************************************************
 * Description: 
 *
 * Documents: https://github.com/hiramtan/HiSocket_unity
 * Author: hiramtan@live.com
***************************************************************/

using System.Collections.Generic;

namespace HiSocket.Tcp
{
    internal abstract class ByteBlockOperator
    {
        protected readonly object Locker = new object();
        protected IByteBlockBuffer ByteBlockBuffer { get; }
        public LinkedListNode<byte[]> Node { get; set; }
        public int Position { get; set; }
        public ByteBlockOperator(IByteBlockBuffer byteBlockBuffer)
        {
            ByteBlockBuffer = byteBlockBuffer;
            Node = ByteBlockBuffer.LinkedList.First;
        }
    }
}