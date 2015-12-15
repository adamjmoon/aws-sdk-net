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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AddHeaderAction Object
    /// </summary>  
    public class AddHeaderActionUnmarshaller : IUnmarshaller<AddHeaderAction, XmlUnmarshallerContext>, IUnmarshaller<AddHeaderAction, JsonUnmarshallerContext>
    {
        public AddHeaderAction Unmarshall(XmlUnmarshallerContext context)
        {
            AddHeaderAction unmarshalledObject = new AddHeaderAction();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("HeaderName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.HeaderName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("HeaderValue", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.HeaderValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        public AddHeaderAction Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static AddHeaderActionUnmarshaller _instance = new AddHeaderActionUnmarshaller();        

        public static AddHeaderActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}