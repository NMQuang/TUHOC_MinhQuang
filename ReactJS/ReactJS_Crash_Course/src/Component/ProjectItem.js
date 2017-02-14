import React, { Component } from 'react';


class ProjectItem extends Component {
  deleteProject(id){
    this.props.onDelete(id);
  }
  render() {
    console.log(this.props);
    return (
      <li className="Project">
        <strong>{this.props.listProjectItem.title}</strong> - {this.props.listProjectItem.category} -- <a href="#" onClick={this.deleteProject.bind(this,this.props.listProjectItem.id)}>X</a>
      </li>
    );
  }
}

export default ProjectItem;
