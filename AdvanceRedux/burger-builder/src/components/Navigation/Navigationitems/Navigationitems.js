import React from 'react'
import './Navigationitems.css'
import NavigationItem from './Navigationitem/Navigationitem'

const navigationItems=(props) =>(
<ul className="NavigationItems">
    <NavigationItem link="/" exact>Burger Builder</NavigationItem>

    <NavigationItem link="/orders">Orders</NavigationItem>
</ul>

);

export default navigationItems;