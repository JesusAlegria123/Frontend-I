import { useState } from 'react';
import TaskItem from './TaskItem';
import './App.css';

function App() {
  const [task, setTask] = useState('');
  const [tasks, setTasks] = useState([]);
  const [error, setError] = useState('');

  const addTask = () => {
    // Validación: tarea vacía
    if (task.trim() === '') {
      setError('❌ No puedes agregar una tarea vacía');
      setTimeout(() => setError(''), 3000);
      return;
    }

    // Validación: tarea duplicada
    const isDuplicate = tasks.some(t => t.text.toLowerCase() === task.trim().toLowerCase());
    if (isDuplicate) {
      setError('❌ Esta tarea ya existe en la lista');
      setTimeout(() => setError(''), 3000);
      return;
    }

    // Agregar tarea con fecha y hora
    const newTask = {
      text: task.trim(),
      createdAt: new Date(),
      completed: false
    };

    setTasks([...tasks, newTask]);
    setTask('');
    setError('');
  };

  const handleKeyPress = (e) => {
    if (e.key === 'Enter') {
      addTask();
    }
  };

  const deleteTask = (index) => {
    const newTasks = tasks.filter((_, i) => i !== index);
    setTasks(newTasks);
  };

  const completeTask = (index) => {
    const newTasks = [...tasks];
    newTasks[index].completed = !newTasks[index].completed;
    setTasks(newTasks);
  };

  const formatDateTime = (date) => {
    return new Intl.DateTimeFormat('es-PE', {
      day: '2-digit',
      month: '2-digit',
      year: 'numeric',
      hour: '2-digit',
      minute: '2-digit'
    }).format(date);
  };

  return (
    <div className="container">
      <h1>📝 Lista de Tareas</h1>
      
      {/* Contador de tareas */}
      <div className="task-counter">
        <span>Total: {tasks.length}</span>
        <span>Completadas: {tasks.filter(t => t.completed).length}</span>
        <span>Pendientes: {tasks.filter(t => !t.completed).length}</span>
      </div>

      <div className="input-container">
        <input
          type="text"
          value={task}
          onChange={(e) => setTask(e.target.value)}
          onKeyPress={handleKeyPress}
          placeholder="Escribe una tarea..."
        />
        <button onClick={addTask}>Agregar</button>
      </div>

      {/* Mensaje de error */}
      {error && <div className="error-message">{error}</div>}

      <ul className="task-list">
        {tasks.map((t, index) => (
          <li key={index} className={`task-item ${t.completed ? 'completed' : ''}`}>
            <div className="task-content">
              <span className="task-text">{t.text}</span>
              <span className="task-date">{formatDateTime(t.createdAt)}</span>
            </div>
            <div className="task-buttons">
              <button 
                className="btn-complete" 
                onClick={() => completeTask(index)}
                title="Completar tarea"
              >
                {t.completed ? '↺' : '✓'}
              </button>
              <button 
                className="btn-delete" 
                onClick={() => deleteTask(index)}
                title="Eliminar tarea"
              >
                🗑️
              </button>
            </div>
          </li>
        ))}
      </ul>

      {tasks.length === 0 && (
        <p className="empty-message">No hay tareas. ¡Agrega una para comenzar! 🚀</p>
      )}
    </div>
  );
}

export default App;
