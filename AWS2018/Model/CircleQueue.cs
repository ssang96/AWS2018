namespace AWS2018.Datas
{
    /// <summary>
    /// CQueue에 대한 요약 설명입니다.
    /// </summary>
    public class CircleQueue<T>
    {
        /// <summary> 현재 버퍼의 데이터를 넣을 위치 </summary>
        public int Position { get; private set; } = 0;
        /// <summary> 버퍼의 사이즈 </summary>
        public int BufferSize { get; private set; } = 0;
        /// <summary> 버퍼 배열 </summary>
        public T[] Buffer { get; set; } = null;
        
          
        /// <summary>
        /// 버퍼의 사이즈 설정
        /// </summary>
        /// <param name="Size">버퍼의 배열 크기</param>
        /// <remarks>
        /// 버퍼의 크기를 설정하면 m_Sp = 0
        /// m_Size = Size로 설정되고
        /// 배열의 함수 Initialize()를 호출한다.
        /// </remarks>
        public void SetSize(int Size)
        {
            BufferSize = Size;
            Position = 0;

            Buffer = new T[BufferSize];          
        }

        /// <summary>
        /// 버퍼에 데이터를 넣는다.
        /// </summary>
        /// <param name="Data">버퍼에 넣을 데이터(byte)</param>
        /// <returns>없음</returns>
        public void PutData(T Data)
        {
            if (Buffer == null)
                throw new System.Exception("버퍼 크기가 설정 되어 있지 않습니다.");
            Buffer[Position++] = Data;
           
            if (Position >= BufferSize)
                Position = 0;
        }
    }
}
