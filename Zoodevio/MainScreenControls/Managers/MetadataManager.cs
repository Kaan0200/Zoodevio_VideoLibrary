using System;
using Zoodevio.DataModel;
using Zoodevio.DataModel.Objects;

namespace Zoodevio.Managers
{
    public class MetadataManager
    {
        private MainScreenManager _parentManager;
        private MetadataViewControl _control;

        public MetadataManager(MainScreenManager _manager, MetadataViewControl metadataViewControl)
        {
            _parentManager = _manager;
            _control = metadataViewControl;
        }

        public void DisplayVideoFileMetadata(VideoFile file)
        {

            foreach (var tag in file.Tags)
            {
                var type = Tags.GetTagType(tag.TypeId);
                Console.WriteLine("Tag: " + tag.Data);

            }
        }
    }
}