using System;
using Zoodevio.DataModel;
using Zoodevio.DataModel.Objects;

namespace Zoodevio.Managers
{
    public class MetadataManager
    {
        public VideoFile CurrentFile { get; set; }
        private MainScreenManager _parentManager;
        private MetadataViewControl _control;

        public MainScreenManager ParentManager => _parentManager;

        public MetadataManager(MainScreenManager _manager, MetadataViewControl metadataViewControl)
        {
            _parentManager = _manager;
            _control = metadataViewControl;
        }

        public void DisplayVideoFileMetadata(VideoFile file)
        {
            _control.PopulateFields(file);
        }

        public void Update(int fileId)
        {
            DisplayVideoFileMetadata(Files.GetFile(fileId));
        }

        public void Clear()
        {
            _control.ClearFields();
        }
    }
}