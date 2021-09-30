using System.Linq;
using Leopotam.Ecs;
using UnityEngine;
using UnityEngine.UI;

namespace Tetris
{
    sealed partial class InitAllSystem
    {
        private void CreateLevelCompleteTask()
        {
            if (_level.isTaskQuota) CreteTaskQuota();
            if (_level.isTaskSurvive) CreteTaskSurvive();
            if (_level.isTaskDestroyBlock) CreteTaskDestroyBlock();
            
        }

        private void CreteTaskDestroyBlock()
        {
            
            GameObject o= GameObject.Find("Canvas").GetComponentsInChildren<RectTransform>(true).First(x => x.name == "TaskDestroy").gameObject;
            o.SetActive(true);
            
            EcsEntity ent = _world.NewEntity();
            ent.Get<TaskDestroyBlockComponent>();
        }

        private void CreteTaskSurvive()
        {
            
            EcsEntity ent = _world.NewEntity();
            ent.Get<TaskSurviveComponent>().Seconds = _level.Seconds;
            
            GameObject o= GameObject.Find("Canvas").GetComponentsInChildren<RectTransform>(true).First(x => x.name == "TaskSurvive").gameObject;
            o.SetActive(true);
            Text text = o.GetComponentInChildren<Text>();
            text.text = ((int)_level.Seconds).ToString("D2");
            ent.Get<TaskSurviveComponent>().text = text;
        }

        private void CreteTaskQuota()
        {
            EcsEntity ent = _world.NewEntity();
            ent.Get<TaskQuotaComponent>().Line1 = _level.Line1;
            ent.Get<TaskQuotaComponent>().Line2 = _level.Line2;
            ent.Get<TaskQuotaComponent>().Line3 = _level.Line3;
            ent.Get<TaskQuotaComponent>().Line4 = _level.Line4;
            
            GameObject o= GameObject.Find("Canvas").GetComponentsInChildren<RectTransform>(true).First(x => x.name == "TaskQuota").gameObject;
            o.SetActive(true);

            ent.Get<TaskQuotaComponent>().textLine1 = o.GetComponentsInChildren<Text>().First(x => x.name == "Text1");
            ent.Get<TaskQuotaComponent>().textLine2 = o.GetComponentsInChildren<Text>().First(x => x.name == "Text2");
            ent.Get<TaskQuotaComponent>().textLine3 = o.GetComponentsInChildren<Text>().First(x => x.name == "Text3");
            ent.Get<TaskQuotaComponent>().textLine4 = o.GetComponentsInChildren<Text>().First(x => x.name == "Text4");

            ent.Get<TaskQuotaComponent>().textLine1.text = _level.Line1.ToString("D2");
            ent.Get<TaskQuotaComponent>().textLine2.text = _level.Line2.ToString("D2");
            ent.Get<TaskQuotaComponent>().textLine3.text = _level.Line3.ToString("D2");
            ent.Get<TaskQuotaComponent>().textLine4.text = _level.Line4.ToString("D2");


        }
    }
}