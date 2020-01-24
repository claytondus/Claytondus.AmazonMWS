/*******************************************************************************
 * Copyright 2009-2015 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Subscription
 * API Version: 2013-07-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:27:11 GMT 2015
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Subscriptions.Model
{
    public class Subscription : AbstractMwsObject
    {

        private string _notificationType;
        private Destination _destination;
        private bool _isEnabled;

        /// <summary>
        /// Gets and sets the NotificationType property.
        /// </summary>
        public string NotificationType
        {
            get { return this._notificationType; }
            set { this._notificationType = value; }
        }

        /// <summary>
        /// Sets the NotificationType property.
        /// </summary>
        /// <param name="notificationType">NotificationType property.</param>
        /// <returns>this instance.</returns>
        public Subscription WithNotificationType(string notificationType)
        {
            this._notificationType = notificationType;
            return this;
        }

        /// <summary>
        /// Checks if NotificationType property is set.
        /// </summary>
        /// <returns>true if NotificationType property is set.</returns>
        public bool IsSetNotificationType()
        {
            return this._notificationType != null;
        }

        /// <summary>
        /// Gets and sets the Destination property.
        /// </summary>
        public Destination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        /// <summary>
        /// Sets the Destination property.
        /// </summary>
        /// <param name="destination">Destination property.</param>
        /// <returns>this instance.</returns>
        public Subscription WithDestination(Destination destination)
        {
            this._destination = destination;
            return this;
        }

        /// <summary>
        /// Checks if Destination property is set.
        /// </summary>
        /// <returns>true if Destination property is set.</returns>
        public bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the IsEnabled property.
        /// </summary>
        public bool IsEnabled
        {
            get { return this._isEnabled; }
            set { this._isEnabled = value; }
        }

        /// <summary>
        /// Sets the IsEnabled property.
        /// </summary>
        /// <param name="isEnabled">IsEnabled property.</param>
        /// <returns>this instance.</returns>
        public Subscription WithIsEnabled(bool isEnabled)
        {
            this._isEnabled = isEnabled;
            return this;
        }

        /// <summary>
        /// Checks if IsEnabled property is set.
        /// </summary>
        /// <returns>true if IsEnabled property is set.</returns>
        public bool IsSetIsEnabled()
        {
            return this._isEnabled != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _notificationType = reader.Read<string>("NotificationType");
            _destination = reader.Read<Destination>("Destination");
            _isEnabled = reader.Read<bool>("IsEnabled");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("NotificationType", _notificationType);
            writer.Write("Destination", _destination);
            writer.Write("IsEnabled", _isEnabled);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Subscriptions/2013-07-01", "Subscription", this);
        }

        public Subscription() : base()
        {
        }
    }
}
