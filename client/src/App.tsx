import { List, ListItem, ListItemText, Typography } from '@mui/material';
import React, { useEffect, useState } from 'react';

function App() {
  const [activites, setActivities] = useState<Activity[]>([]);

  useEffect(() => {
     fetch('https://localhost:5001/api/activities/')
      .then(response => response.json())
      .then(data => setActivities(data))

      return () => {} 
    },[])

  const title = 'Reactivities';

  return (
    <>
      <Typography variant='h3' className="app" style={{color: 'Blue'}}>{title}</Typography>

      <List>
        {activites.map(activity => (
          <ListItem key={activity.id}>
            <ListItemText>
              {activity.title}
            </ListItemText>
          </ListItem>
        ))}
      </List>
    </>
    
  )
}

export default App
