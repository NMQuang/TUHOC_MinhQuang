//id container
var Counter = React.createClass({
  incrementCount: function(){
    this.setState({
      count: this.state.count + 1
    });
  },
  getInitialState: function(){
     return {
       count: 0
     }
  },
  render: function(){
    return (
      <div className="counter">
        <h1>Count: {this.state.count}</h1>
        <button type="button" className="button" onClick={this.incrementCount}>Increment</button>
      </div>
    );
  },
  componentDidMount(){
    setInterval(this.incrementCount,1000);
  }
});

ReactDOM.render(<Counter/>,document.getElementById("container"));



//Search list

var FiltList = React.createClass({

  filterList:function(event){
    var updateList = this.state.listItem;
    updateList = updateList.filter(function(item){
      return item.toLowerCase().search(event.target.value.toLowerCase()) !== -1;
    });
    this.setState({
      items:updateList
    })
  },
  getInitialState:function(){
    return{
      listItem:["Java Spring","NodeJS","Javascript","C/C++"],
      items:[]
    }
  },
  componentWillMount: function(){
    this.setState({items: this.state.listItem})
  },
  render:function(){
    return (
    <div className="search">
      <input type="text" className="button" placeholder="Tìm kiếm..." onChange={this.filterList}/>

      <List quang = {this.state.items}/>
    </div>
    );
  }
});

var List = React.createClass({
  render:function(){
    return (
      <ul>{this.props.quang.map(function(item){
        return <li key={item}>{item}</li>
      })}</ul>
    );
  }
});
ReactDOM.render(<FiltList/>,document.getElementById("container1"));




//Change Image
var Image = React.createClass({

    changeImage(){
      this.setState(
        {Hinh: (this.state.Hinh % 7) + 1},

      );

    },
    getInitialState(){
      return {
        Hinh:1

      }
    },
    render(){
      return(
      <div className="my-love">
        <img src={"image/anh"+this.state.Hinh+".jpg" }/>

      </div>
      );
    },
    componentDidMount(){
      setInterval(this.changeImage,1000);
    }
});

ReactDOM.render(<Image/>,document.getElementById("container2"));


// App Note dùng React và Ajax

var Note = React.createClass({
  save(){
    var that = this;
    $.post("/update",{idSua:this.props.id,textSua:this.refs.txt.value},function(data){
        list.setState({Mang:data})
        that.setState({onEdit:false})
    })
  },
  cancel(){
  this.setState({onEdit:false})
  },

  edit(){
    this.setState({onEdit:true})
  },

  getInitialState(){
    return {onEdit:false}
  },

  delete(){
    $.post("/delete",{idXoa:this.props.id},function(data){
      list.setState({Mang:data})
    });
  },
  render(){
    if(this.state.onEdit){
      return(
      <div className="list-group-item">
        <input className="input-group" defaultValue={this.props.children} ref="txt"/>
        <button className="btn-group" onClick={this.save}>Lưu</button>
        <button className="btn-group" onClick={this.cancel}>Hủy</button>
      </div>
      );
    }else{
      return(
      <div className="list-group-item">
        {this.props.children}
        <button className="btn-group" onClick={this.delete}>Xóa</button>
        <button className="btn-group" onClick={this.edit}>Sửa</button>

      </div>
      );
    }

  }
});

function addNote(){
  ReactDOM.render(
    <InputDiv/>,
    document.getElementById("div-add")
  );
}

var list;

var ListNode = React.createClass({
  getInitialState(){
    list = this;
    return {
      Mang:[]
    }
  },
  render(){
    return(
      <div className="jumbotron">
      <div className="col-sm-8">
        <div className="list-group">
          <div id="div-add"></div>
          <button className="btn-group" onClick={addNote}>ADD</button>
          {
            this.state.Mang.map(function(tenNote,index){
              return <Note key={index} id={index}>{tenNote}</Note>
            })
          }
          </div>
        </div>
      </div>
    );
  },

  //Đưa dữ liệu từ server lên listNode
  componentDidMount(){
    var that = this;
    $.post("/getNode",function(data){
        that.setState({Mang:data});
    });
  }
});

var InputDiv = React.createClass({
  sendNote(){
    $.post("/add",{note:this.refs.txt.value},function(data){
      list.setState({Mang:data});
    })

    //Khi click send thì sẽ ẩn tab Input
    ReactDOM.unmountComponentAtNode(document.getElementById("div-add"));
  },
  render(){
    return(
    <div>
      <input className="input-group" type="text" ref="txt" placeholder="write note here"/>
      <button className="btn-group" onClick ={this.sendNote}>Send</button>
    </div>
    );
  }
});


ReactDOM.render(
  <div>
    <ListNode/>
  </div>
  ,
  document.getElementById("container3")
);

//mapping data

var App = React.createClass({
  getInitialState(){
    return{
      text:'',
      todos:[
        {
          id:1,
          name:'Đạt được bằng tiếng Anh ra trường'
        },
        {
          id:2,
          name:'Lấy được bằng N3 tiếng Nhật khi ra trường'
        },
        {
          id:3,
          name:'Thành thạo trong việc phát triển web bằng Java Spring và Javascript'
        }
      ]
    }
  },
  render:function(){
    return (
      <div>
        <TodoForm todo_item={this.state.todos}/>
      </div>
    )
  }
});

var TodoForm = React.createClass({
  render:function(){
    return(
      <ul className="list-group">
        {
          this.props.todo_item.map(todo =>{
            return <li className="list-group-item" todo={todo} key={todo.id}>{todo.name}</li>
          })
        }
      </ul>
    )
  }
});

ReactDOM.render(<App/>,document.getElementById('container4'));
