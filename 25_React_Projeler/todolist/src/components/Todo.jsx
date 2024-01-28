import React from "react";

const Todo = ({ todo, todos, setTodos }) => {
  const deleteHandler = () => {
    setTodos(todos.filter((el) => el.id !== todo.id));
  };

  const completeHandler = () => {
    setTodos(
      todos.map((item) => {
        if (item.id === todo.id) {
          return {
            ...item,
            completed: !item.completed,
          };
        }
        return item;
      })
    );
  };

  return (
    <div className={`todo ${todo.completed ? "completed" : ""}`}>
      <div className="complete-btn" onClick={completeHandler}>
        <i className="fas fa-check-circle"></i>
      </div>
      <li className="todo-item" key={todo.id}>
        {todo.text}
      </li>
      <div className="trash-btn" onClick={deleteHandler}>
        <i className="fas fa-minus-circle"></i>
      </div>
    </div>
  );
};

export default Todo;
