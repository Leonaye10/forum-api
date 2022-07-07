﻿using forum_api_back.DataAccess.DataObjects;

namespace forum_api_back.Repositories
{
    public class TopicRepository
    {
        private readonly forumdbContext context;
        public TopicRepository(forumdbContext Context)
        {
            this.context = Context;
        }


        public Topic Create(Topic topic)
        {
            this.context.Topics.Add(topic);
            this.context.SaveChanges();
            return topic;
        }

        public Topic Delete(int id)
        {
            Topic topic = this.context.Topics.FirstOrDefault(t => t.Idtopic == id);
            this.context.Topics.Remove(topic);
            this.context.SaveChanges();
            return topic;
        }

        public Topic GetTopicId(int id)
        {
            Topic topic = this.context.Topics.FirstOrDefault(t => t.Idtopic == id);
            return topic;
        }

        public List<Topic> GetAllTopic()
        {
            List<Topic> topics = this.context.Topics.ToList();
            return topics;
        }


        public Topic UpdateTopic(Topic topic)
        {
            this.context.Topics.Update(topic);
            this.context.SaveChanges();
            return topic;
        }

    }
}
