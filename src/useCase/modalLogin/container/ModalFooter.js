import React, { Component } from 'react';
import LogInButton from '../component/LogInButton';
import ModalCloseButton from '../component/ModalCloseButton';
import { actionCreators } from '../../../common/redux/reducer';
import {loginUser} from '../../../common/functions/API';

class ModalFooter extends Component {
  onLogin = (text) => {
    loginUser(this.props.usernameInput, this.props.passwordInput).then((response) => {
      if (response.status == 200 && response.data.userID !== '0' )
      {
        this.props.dispatch(actionCreators.setUserID(response.data.userID));
        this.props.dispatch(actionCreators.setUsername(this.props.usernameInput));
        document.getElementsByName('closer')[0].click();
      }
    });
  }
  
  render() {
    return (
      <div class="modal-footer">
        <ModalCloseButton />
        <LogInButton onLogin={this.props.OnLogin} name="Logga In" styleText="btn btn-primary"/>
        <button name="closer" hidden data-dismiss="modal"/>
      </div>   
    );
  }
}

export default ModalFooter;