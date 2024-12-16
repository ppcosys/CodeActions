import { useEffect, useState } from 'react'
import './App.css'
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';

function App() {
  const [events, setEvents] = useState([]);
  
  useEffect(() => {
    axios.get('http://localhost:5000/api/events')
      .then(response => {
        setEvents(response.data)
      })
  }, [])

  return (
    <div>
      <Header as='h2' icon='users' content='Events' />
      <List>
        {events.map((event: any) => (
          <List.Item key = {event.id}>
            {event.title}
          </List.Item>
        ))}
      </List>
    </div>
  )
}

export default App
