using GalaSoft.MvvmLight;
using System;

namespace ProjectTimer.Models
{
    public class ProjectsModel : ObservableObject
    {
        private bool _isDirty;
        public bool IsDirty
        {
            get { return _isDirty; }
            set { Set(nameof(IsDirty), ref _isDirty, value); }
        }

        public int Id { get; set; }

        private string _projectName;
        public string ProjectName
        {
            get { return _projectName; }
            set
            {
                if (Set(nameof(ProjectName), ref _projectName, value))
                {
                    IsDirty = true;
                }
            }
        }

        private TimeSpan _totalDuration;
        public TimeSpan TotalDuration
        {
            get { return _totalDuration; }
            set
            {
                if (Set(nameof(TotalDuration), ref _totalDuration, value))
                {
                    IsDirty = true;
                }
            }
        }
    }
}
