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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMaintenanceStartTime operation.
    /// This operation updates a gateway's weekly maintenance start time information, including
    /// day and time of the week. The maintenance time is the time in your gateway's time
    /// zone.
    /// </summary>
    public partial class UpdateMaintenanceStartTimeRequest : AmazonStorageGatewayRequest
    {
        private int? _dayOfWeek;
        private string _gatewayARN;
        private int? _hourOfDay;
        private int? _minuteOfHour;

        /// <summary>
        /// Gets and sets the property DayOfWeek. 
        /// <para>
        /// The maintenance start time day of the week.
        /// </para>
        /// </summary>
        public int DayOfWeek
        {
            get { return this._dayOfWeek.GetValueOrDefault(); }
            set { this._dayOfWeek = value; }
        }

        // Check to see if DayOfWeek property is set
        internal bool IsSetDayOfWeek()
        {
            return this._dayOfWeek.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

        /// <summary>
        /// Gets and sets the property HourOfDay. 
        /// <para>
        /// The hour component of the maintenance start time represented as <i>hh</i>, where <i>hh</i>
        /// is the hour (00 to 23). The hour of the day is in the time zone of the gateway.
        /// </para>
        /// </summary>
        public int HourOfDay
        {
            get { return this._hourOfDay.GetValueOrDefault(); }
            set { this._hourOfDay = value; }
        }

        // Check to see if HourOfDay property is set
        internal bool IsSetHourOfDay()
        {
            return this._hourOfDay.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinuteOfHour. 
        /// <para>
        /// The minute component of the maintenance start time represented as <i>mm</i>, where
        /// <i>mm</i> is the minute (00 to 59). The minute of the hour is in the time zone of
        /// the gateway.
        /// </para>
        /// </summary>
        public int MinuteOfHour
        {
            get { return this._minuteOfHour.GetValueOrDefault(); }
            set { this._minuteOfHour = value; }
        }

        // Check to see if MinuteOfHour property is set
        internal bool IsSetMinuteOfHour()
        {
            return this._minuteOfHour.HasValue; 
        }

    }
}