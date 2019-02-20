using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task
{
    private string taskType;
    private bool[] subtasks;

    public Task(bool[] subtasks)
    {
        this.subtasks = subtasks;
        if(subtasks.Length == 1)
        {
            taskType = "Entitlement";
        }
        else if(subtasks.Length == 2)
        {
            taskType = "Request";
        }
        else
        {
            taskType = "Bug";
        }
    }

    public bool IsComplete()
    {
        foreach (bool subtask in subtasks){
            if (!subtask)
            {
                return false;
            }
        }
        return true;
    }

    public string GetTaskType()
    {
        return taskType;
    }

    public bool[] GetSubtasks()
    {
        return subtasks;
    }

    public void SetSubtaskComplete(int index)
    {
        subtasks[index] = true;
    }
}
