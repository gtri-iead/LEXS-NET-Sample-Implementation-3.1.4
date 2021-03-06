﻿using System;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

public interface IOperationBehavior
{
   // Methods
   void AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters);
   void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation);
   void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation);
   void Validate(OperationDescription operationDescription);
}




