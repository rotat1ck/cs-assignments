class Teacher {
    // public event Student.ExamDelegate? examEvent;
    //EventHandler<T> 
    // public EventHandler<ExamEventArgs> examEvent;

    // public void Exam(ExamEventArgs task) {
    //     if (examEvent != null) {
    //         examEvent(this, task);
    //     }
    // }

    // public void Exam(string task) {
    //     if (examEvent != null) {
    //         examEvent(task);
    //     }
    // }

    SortedList<int, Student.ExamDelegate> _sortedEvents = new();
    Random _rand = new();

    public event Student.ExamDelegate examEvent {
        add {
            for (int key ; ;) {
                key = _rand.Next();
                if (!_sortedEvents.ContainsKey(key)) {
                    _sortedEvents.Add(key, value);
                    break;
                }
            }
        }

        remove {
            _sortedEvents.RemoveAt(_sortedEvents.IndexOfValue(value));
        }
    }

    public void Exam(string task) {
        foreach (int item in _sortedEvents.Keys) {
            if (_sortedEvents[item] != null) {
                _sortedEvents[item](task);
            }
        }
    }
} 