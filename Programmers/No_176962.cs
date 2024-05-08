using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Programmers
{
    /// <summary>
    /// 
    /// * plan의 구성은 { name, start, playtime } 으로 구성
    /// 
    /// * 조건
    ///  - 과제는 시작하기로 한 시각이 되면 시작한다.
    ///  
    ///  - 새로운 과제를 시작할 시각이 되었을 때,
    ///    기존에 진행 중이던 과제가 있다면 진행 중이던 과제를 멈추고 새로운 과제를 진행함
    ///    
    ///  - 진행 중이던 과제를 끝냈을 때, 잠시 멈춘 과제가 있다면 멈춰둔 과제를 이어서 진행
    ///    만약, 과제를 끝낸 시각에 새로 시작해야 하는 과제와 잠시 멈춘 과제가 있다면 새로 시작해야 하는 과제를 우선 진행
    ///    
    ///  - 멈춰둔 과제가 여러 개일 경우, 가장 최근에 멈춘 과제부터 시작
    /// 
    /// </summary>



    internal class Task
    {
        public string Name { get; set; } = string.Empty;
        public int StartTime { get; set; } = 0;
        public int PlayTime { get; set; } = 0;
    }


    internal class No_176962
    {
        static void Main(string[] args)
        {
            string[,] plans = { { "korean", "11:40", "30" }, { "english", "12:10", "20" }, { "math", "12:30", "40" } };

            Console.WriteLine(Solution(plans));
        }


        public static string[] Solution(string[,] plans)
        {
            string[] answer = new string[] { };
            List<Task> taskList = new List<Task>();
            Stack<Task> taskStack = new Stack<Task>();
            int finishTime = 0;
            int currentTime = 0;
            int listIndex = 0;

            // Plans을 Task로 나누어 삽입
            for (int i = 0; i < plans.GetLength(0); i++)
            {
                Task newTask = new Task();
                newTask.Name = plans[i, 0];
                newTask.StartTime = CalculateTime(plans[i, 1]);
                newTask.PlayTime = int.Parse(plans[i, 2]);
                finishTime += newTask.PlayTime;

                taskList.Add(newTask);
            }

            // StartTime으로 오름차순 정렬
            taskList = taskList.OrderBy(t => t.StartTime).ToList();

            finishTime += taskList[0].StartTime;
            currentTime = taskList[0].StartTime;
            

            while (finishTime != currentTime)
            {
                // 이전 업무가 다음 업무 시작 전에 끝날 경우,
                if (taskList[listIndex].StartTime + taskList[listIndex].PlayTime <= taskList[listIndex + 1].StartTime)
                {
                    // 다음 업무가 있으면
                    if (false)
                    {

                    }
                    // 다음 업무 없고, 기존 업무가 있음
                    else if (true)
                    {

                    }
                }
                // 이전 업무 중 다음 업무가 시작될 경우,
                else
                {

                }
            }

            return answer;
        }


        public static int CalculateTime(string timeData)
        {
            int result = 0;
            int[] dataToIntArray = Array.ConvertAll(timeData.Split(':'), int.Parse);
            result = dataToIntArray[0] * 60 + dataToIntArray[1];

            return result;
        }
    }
}
