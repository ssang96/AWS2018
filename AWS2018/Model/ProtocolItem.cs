using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS2018.Datas
{
    /// <summary> Check Function Delegate </summary>
    public delegate bool CheckFunction(object sender, CircleQueue<byte> m_Queue);
    /// <summary> Catch Function Delegate </summary>
    public delegate bool CatchFunction(object sender, byte[] Data);

    /// <summary>
    /// ProtocolItem 
    /// </summary>
    /// <remarks>
    /// 내부 큐버퍼를 가지며 데이터가 들어 올때 Delegate를 호출한다.
    /// </remarks>
    public class ProtocolItem
    {
        /// <summary> 프로토콜 검사를 할 것인지 설정 </summary>
        private bool isUsing;
        /// <summary> 내부 큐 버퍼 </summary>
        private CircleQueue<byte> Queue = null;
        /// <summary> Check Delegate  </summary>
        private CheckFunction OnCheckFunc = null;
        /// <summary> Catch Delegate </summary>
        private CatchFunction OnCatchFunc = null;
    
        public CheckFunction OnCheck
        {
            get { return OnCheckFunc; }
            set { OnCheckFunc = value; }
        }

        public CatchFunction OnCatch
        {
            get { return OnCatchFunc; }
            set { OnCatchFunc = value; }
        }

        public bool Using
        {
            get { return this.isUsing; }
            set { this.isUsing = value; }
        }

        public ProtocolItem()
        {
            Queue = null;
            isUsing = false;
            Queue = new CircleQueue<byte>();
        }

        /// <summary>
        /// 데이터를 내부 큐에 넣고 Delegate를 호출한다.
        /// </summary>
        /// <param name="data"> 데이터 </param>
        public void ProcessingData(byte data)
        {
            // 내부 큐 버퍼에 데이터를 넣는다.
            Queue.PutData(data);

            if (this.isUsing == true)
            {
                // Delegate를 호출한다.
                if (Check() == true)
                    Catch();
            }
        }

        /// <summary>
        /// Check 함수( Delegate CheckFunction을 호출한다. )
        /// </summary>
        /// <returns> Delegate의 리턴 값</returns>
        public virtual bool Check()
        {
            if (OnCheckFunc == null) return false;
            return OnCheckFunc(this, Queue);
        }

        /// <summary>
        /// Catch 함수( Delegate CatchFunction을 호출한다. )
        /// </summary>
        /// <returns> Delegate CatchFunction의 리턴 값</returns>
        public virtual bool Catch()
        {
            if (OnCatchFunc == null) return false;
            // 데이터를 순서 대로 배열에 넣은 후에 delegate 호출
            byte[] data = new byte[Queue.BufferSize];

            for (int i = 0; i < Queue.BufferSize; i++)
                data[i] = Queue.Buffer[(Queue.Position + i + Queue.BufferSize) % Queue.BufferSize];
            return OnCatchFunc(this, data);
        }
    }
}
