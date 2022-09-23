using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIteratorParttern
{
    public class ArtsIterator : IIterator
    {
        public string[] Subjects;
        private int position;

        //constructor
        public ArtsIterator(String[] subjects) {
            this.Subjects = subjects;
            position = 0;
        }
        //Phương thức First () đặt lại con trỏ về phần tử đầu tiên trước bạn
        //bắt đầu duyệt qua cấu trúc dữ liệu.
        public void First()
        {
            position = 0;
        }
        // Phương thức Next () trả về phần tử tiếp theo trong vùng chứa.
        public string Next()
        {
            return Subjects[position++];
        }

        //• IsCollectionEnds () xác thực xem có bất kỳ phần tử tiếp theo nào không
        public bool IsCollectionEnds()
        {
            if(position >= Subjects.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //• Phương thức CurrentItem () trả về phần tử hiện tại của
        //vùng chứa mà trình vòng lặp đang trỏ vào một thời điểm cụ thể.
        public string CurrentItem()
        {
            return Subjects[position];
        }
    }
}
