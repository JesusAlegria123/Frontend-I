* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

body {
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
  background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
  min-height: 100vh;
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 20px;
}

.container {
  background: white;
  padding: 40px;
  border-radius: 20px;
  box-shadow: 0 20px 60px rgba(0, 0, 0, 0.3);
  width: 100%;
  max-width: 650px;
}

h1 {
  text-align: center;
  color: #333;
  margin-bottom: 20px;
  font-size: 2.5rem;
}

/* Contador de tareas */
.task-counter {
  display: flex;
  justify-content: space-around;
  background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
  padding: 15px;
  border-radius: 10px;
  margin-bottom: 25px;
  color: white;
  font-weight: bold;
}

.task-counter span {
  font-size: 14px;
}

/* Input y botón */
.input-container {
  display: flex;
  gap: 10px;
  margin-bottom: 15px;
}

input {
  flex: 1;
  padding: 15px;
  border: 2px solid #e0e0e0;
  border-radius: 10px;
  font-size: 16px;
  transition: all 0.3s;
}

input:focus {
  outline: none;
  border-color: #667eea;
  box-shadow: 0 0 0 3px rgba(102, 126, 234, 0.1);
}

button {
  padding: 15px 30px;
  background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
  color: white;
  border: none;
  border-radius: 10px;
  font-size: 16px;
  font-weight: bold;
  cursor: pointer;
  transition: transform 0.2s, box-shadow 0.2s;
}

button:hover {
  transform: translateY(-2px);
  box-shadow: 0 5px 15px rgba(102, 126, 234, 0.4);
}

button:active {
  transform: translateY(0);
}

/* Mensaje de error */
.error-message {
  background: #fee;
  color: #c33;
  padding: 12px;
  border-radius: 8px;
  margin-bottom: 15px;
  border-left: 4px solid #c33;
  animation: shake 0.3s;
}

@keyframes shake {
  0%, 100% { transform: translateX(0); }
  25% { transform: translateX(-10px); }
  75% { transform: translateX(10px); }
}

/* Lista de tareas */
.task-list {
  list-style: none;
  max-height: 400px;
  overflow-y: auto;
}

.task-item {
  background: #f8f9fa;
  padding: 15px 20px;
  margin-bottom: 12px;
  border-radius: 10px;
  border-left: 4px solid #667eea;
  display: flex;
  justify-content: space-between;
  align-items: center;
  transition: all 0.3s;
  animation: slideIn 0.3s;
}

@keyframes slideIn {
  from {
    opacity: 0;
    transform: translateX(-20px);
  }
  to {
    opacity: 1;
    transform: translateX(0);
  }
}

.task-item:hover {
  background: #e9ecef;
  transform: translateX(5px);
}

.task-item.completed {
  background: #d4edda;
  border-left-color: #28a745;
  opacity: 0.7;
}

.task-item.completed .task-text {
  text-decoration: line-through;
  color: #6c757d;
}

.task-content {
  display: flex;
  flex-direction: column;
  gap: 5px;
  flex: 1;
}

.task-text {
  font-size: 16px;
  color: #333;
  font-weight: 500;
}

.task-date {
  font-size: 12px;
  color: #6c757d;
}

.task-buttons {
  display: flex;
  gap: 8px;
}

.task-buttons button {
  padding: 8px 12px;
  font-size: 16px;
  min-width: 40px;
}

.btn-complete {
  background: linear-gradient(135deg, #28a745 0%, #20c997 100%);
}

.btn-complete:hover {
  box-shadow: 0 5px 15px rgba(40, 167, 69, 0.4);
}

.btn-delete {
  background: linear-gradient(135deg, #dc3545 0%, #c82333 100%);
}

.btn-delete:hover {
  box-shadow: 0 5px 15px rgba(220, 53, 69, 0.4);
}

/* Mensaje cuando no hay tareas */
.empty-message {
  text-align: center;
  color: #6c757d;
  padding: 40px;
  font-size: 18px;
}

/* Scrollbar personalizado */
.task-list::-webkit-scrollbar {
  width: 8px;
}

.task-list::-webkit-scrollbar-track {
  background: #f1f1f1;
  border-radius: 10px;
}

.task-list::-webkit-scrollbar-thumb {
  background: #667eea;
  border-radius: 10px;
}

.task-list::-webkit-scrollbar-thumb:hover {
  background: #764ba2;
}

/* Responsive */
@media (max-width: 600px) {
  .container {
    padding: 20px;
  }

  h1 {
    font-size: 2rem;
  }

  .task-counter {
    flex-direction: column;
    gap: 8px;
    align-items: center;
  }

  .input-container {
    flex-direction: column;
  }

  button {
    width: 100%;
  }
}
