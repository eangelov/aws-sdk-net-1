/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the RespondDecisionTaskCompleted operation.
    /// Used by deciders to tell the service that the <a>DecisionTask</a> identified by the
    /// <code>taskToken</code> has successfully completed. The <code>decisions</code> argument
    /// specifies the list of decisions made while processing the task.
    /// 
    ///  
    /// <para>
    /// A <code>DecisionTaskCompleted</code> event is added to the workflow history. The <code>executionContext</code>
    /// specified is attached to the event in the workflow execution history.
    /// </para>
    ///  
    /// <para>
    /// <b>Access Control</b>
    /// </para>
    ///  
    /// <para>
    /// If an IAM policy grants permission to use <code>RespondDecisionTaskCompleted</code>,
    /// it can express permissions for the list of decisions in the <code>decisions</code>
    /// parameter. Each of the decisions has one or more parameters, much like a regular API
    /// call. To allow for policies to be as readable as possible, you can express permissions
    /// on decisions as if they were actual API calls, including applying conditions to some
    /// parameters. For more information, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a>.
    /// </para>
    /// </summary>
    public partial class RespondDecisionTaskCompletedRequest : AmazonSimpleWorkflowRequest
    {
        private List<Decision> _decisions = new List<Decision>();
        private string _executionContext;
        private string _taskToken;

        /// <summary>
        /// Gets and sets the property Decisions. 
        /// <para>
        /// The list of decisions (possibly empty) made by the decider while processing this decision
        /// task. See the docs for the <a>Decision</a> structure for details.
        /// </para>
        /// </summary>
        public List<Decision> Decisions
        {
            get { return this._decisions; }
            set { this._decisions = value; }
        }

        // Check to see if Decisions property is set
        internal bool IsSetDecisions()
        {
            return this._decisions != null && this._decisions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionContext. 
        /// <para>
        /// User defined context to add to workflow execution.
        /// </para>
        /// </summary>
        public string ExecutionContext
        {
            get { return this._executionContext; }
            set { this._executionContext = value; }
        }

        // Check to see if ExecutionContext property is set
        internal bool IsSetExecutionContext()
        {
            return this._executionContext != null;
        }

        /// <summary>
        /// Gets and sets the property TaskToken. 
        /// <para>
        /// The <code>taskToken</code> from the <a>DecisionTask</a>.
        /// </para>
        ///  <important><code>taskToken</code> is generated by the service and should be treated
        /// as an opaque value. If the task is passed to another process, its <code>taskToken</code>
        /// must also be passed. This enables it to provide its progress and respond with results.</important>
        /// </summary>
        public string TaskToken
        {
            get { return this._taskToken; }
            set { this._taskToken = value; }
        }

        // Check to see if TaskToken property is set
        internal bool IsSetTaskToken()
        {
            return this._taskToken != null;
        }

    }
}