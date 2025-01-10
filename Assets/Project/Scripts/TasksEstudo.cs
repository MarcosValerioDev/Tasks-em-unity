using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
public class TasksEstudo : MonoBehaviour
{
    List<Task> tasks;
    void Start()
    {
        //Tasks síncronas
        //tasks = new List<Task>();
        //tasks.Add(Task.Factory.StartNew(CountTaskTest));
        //tasks.Add(Task.Factory.StartNew(CountTaskTest));
        //tasks.Add(Task.Factory.StartNew(CountTaskTest));
        //tasks.Add(Task.Factory.StartNew(CountTaskTest));
        //tasks.Add(Task.Factory.StartNew(CountTaskTest));
        //tasks.Add(Task.Factory.StartNew(CountTaskTest));

        //Task.WaitAll(tasks.ToArray());

        //Tasks assíncronas
        Task.Run(CountTaskTest);
        Task.Run(CountTaskTest);
        Task.Run(CountTaskTest);
        Debug.Log("Concluido");

        Debug.Log("Concluido");
    }

    void CountTaskTest()
    {
        for (int i = 0; i < 1000000; i++) Debug.Log($"Valor {i} TaskId {Task.CurrentId}");
    }
}
