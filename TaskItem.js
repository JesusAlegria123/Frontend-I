import React from 'react';

function TaskItem({ task, index, onComplete, onDelete }) {
  return (
    <li className="task-item">
      <span className="task-text">{task.text}</span>
      <div className="task-buttons">
        <button 
          className="btn-complete" 
          onClick={() => onComplete(index)}
          title="Completar tarea"
        >
          ✓
        </button>
        <button 
          className="btn-delete" 
          onClick={() => onDelete(index)}
          title="Eliminar tarea"
        >
          🗑️
        </button>
      </div>
    </li>
  );
}

export default TaskItem;
