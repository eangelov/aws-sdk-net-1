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
    /// Container for the parameters to the DeprecateDomain operation.
    /// Deprecates the specified domain. After a domain has been deprecated it cannot be used
    /// to create new workflow executions or register new types. However, you can still use
    /// visibility actions on this domain. Deprecating a domain also deprecates all activity
    /// and workflow types registered in the domain. Executions that were started before the
    /// domain was deprecated will continue to run.
    /// 
    ///  <note>This operation is eventually consistent. The results are best effort and may
    /// not exactly reflect recent updates and changes.</note> 
    /// <para>
    /// <b>Access Control</b>
    /// </para>
    ///  
    /// <para>
    /// You can use IAM policies to control this action's access to Amazon SWF resources as
    /// follows:
    /// </para>
    ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
    /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
    /// deny permission to call this action.</li> <li>You cannot use an IAM policy to constrain
    /// this action's parameters.</li> </ul> 
    /// <para>
    /// If the caller does not have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails. The associated event
    /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
    /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a>.
    /// </para>
    /// </summary>
    public partial class DeprecateDomainRequest : AmazonSimpleWorkflowRequest
    {
        private string _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the domain to deprecate.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}