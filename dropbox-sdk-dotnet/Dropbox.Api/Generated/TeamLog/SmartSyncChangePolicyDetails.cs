// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Changed the default Smart Sync policy for team members.</para>
    /// </summary>
    public class SmartSyncChangePolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SmartSyncChangePolicyDetails> Encoder = new SmartSyncChangePolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SmartSyncChangePolicyDetails> Decoder = new SmartSyncChangePolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SmartSyncChangePolicyDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="newValue">New smart sync policy.</param>
        /// <param name="previousValue">Previous smart sync policy.</param>
        public SmartSyncChangePolicyDetails(global::Dropbox.Api.TeamPolicies.SmartSyncPolicy newValue,
                                            global::Dropbox.Api.TeamPolicies.SmartSyncPolicy previousValue = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SmartSyncChangePolicyDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SmartSyncChangePolicyDetails()
        {
        }

        /// <summary>
        /// <para>New smart sync policy.</para>
        /// </summary>
        public global::Dropbox.Api.TeamPolicies.SmartSyncPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous smart sync policy.</para>
        /// </summary>
        public global::Dropbox.Api.TeamPolicies.SmartSyncPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SmartSyncChangePolicyDetails" />.</para>
        /// </summary>
        private class SmartSyncChangePolicyDetailsEncoder : enc.StructEncoder<SmartSyncChangePolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SmartSyncChangePolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamPolicies.SmartSyncPolicy.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamPolicies.SmartSyncPolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SmartSyncChangePolicyDetails" />.</para>
        /// </summary>
        private class SmartSyncChangePolicyDetailsDecoder : enc.StructDecoder<SmartSyncChangePolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SmartSyncChangePolicyDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SmartSyncChangePolicyDetails Create()
            {
                return new SmartSyncChangePolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SmartSyncChangePolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamPolicies.SmartSyncPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamPolicies.SmartSyncPolicy.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
