using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Epiworx.Business;

namespace Epiworx.Service
{
    [Serializable]
    public class SprintService
    {
        public static Sprint SprintFetch(int sprintId)
        {
            return Sprint.FetchSprint(
                new SprintCriteria
                    {
                        SprintId = sprintId
                    });
        }

        public static SprintInfoList SprintFetchInfoList()
        {
            return SprintService.SprintFetchInfoList(
                new SprintCriteria());
        }

        public static SprintInfoList SprintFetchInfoList(IProject project)
        {
            return SprintService.SprintFetchInfoList(
                new SprintCriteria
                    {
                        ProjectId = project.ProjectId
                    });
        }

        public static SprintInfoList SprintFetchInfoList(SprintCriteria criteria)
        {
            return SprintInfoList.FetchSprintInfoList(criteria);
        }

        public static Sprint SprintSave(Sprint sprint)
        {
            if (!sprint.IsValid)
            {
                return sprint;
            }

            Sprint result;

            if (sprint.IsNew)
            {
                result = SprintService.SprintInsert(sprint);
            }
            else
            {
                result = SprintService.SprintUpdate(sprint);
            }

            return result;
        }

        public static Sprint SprintInsert(Sprint sprint)
        {
            sprint = sprint.Save();

            FeedService.FeedAdd("Created", sprint);

            return sprint;
        }

        public static Sprint SprintUpdate(Sprint sprint)
        {
            sprint = sprint.Save();

            FeedService.FeedAdd("Updated", sprint);

            return sprint;
        }

        public static Sprint SprintNew()
        {
            return Sprint.NewSprint();
        }

        public static bool SprintDelete(Sprint sprint)
        {
            Sprint.DeleteSprint(
                new SprintCriteria
                    {
                        SprintId = sprint.SprintId
                    });

            FeedService.FeedAdd("Deleted", sprint);

            return true;
        }

        public static bool SprintDelete(int sprintId)
        {
            return SprintService.SprintDelete(
                SprintService.SprintFetch(sprintId));
        }
    }
}