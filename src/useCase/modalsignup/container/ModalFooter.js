import React, { Component } from 'react';
import SignupButton from '../component/SignupButton';
import ModalCloseButton from '../component/ModalCloseButton';

class ModalFooter extends Component {
  render() {
    return (
      <div class="modal-footer">
        <ModalCloseButton />
        <SignupButton onClick={this.props.OnCreateUserSubmit} name="Bli Medlem"/>
      </div>   
    );
  }
}

export default ModalFooter;