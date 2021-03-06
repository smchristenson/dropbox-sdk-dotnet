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
    /// <para>Changed who can access shared folder via link.</para>
    /// </summary>
    public class SharedFolderChangeLinkPolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedFolderChangeLinkPolicyDetails> Encoder = new SharedFolderChangeLinkPolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedFolderChangeLinkPolicyDetails> Decoder = new SharedFolderChangeLinkPolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedFolderChangeLinkPolicyDetails" /> class.</para>
        /// </summary>
        /// <param name="newValue">New shared folder link policy.</param>
        /// <param name="previousValue">Previous shared folder link policy. Might be missing
        /// due to historical data gap.</param>
        public SharedFolderChangeLinkPolicyDetails(global::Dropbox.Api.Sharing.SharedLinkPolicy newValue,
                                                   global::Dropbox.Api.Sharing.SharedLinkPolicy previousValue = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedFolderChangeLinkPolicyDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedFolderChangeLinkPolicyDetails()
        {
        }

        /// <summary>
        /// <para>New shared folder link policy.</para>
        /// </summary>
        public global::Dropbox.Api.Sharing.SharedLinkPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous shared folder link policy. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public global::Dropbox.Api.Sharing.SharedLinkPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedFolderChangeLinkPolicyDetails" />.</para>
        /// </summary>
        private class SharedFolderChangeLinkPolicyDetailsEncoder : enc.StructEncoder<SharedFolderChangeLinkPolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedFolderChangeLinkPolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.Sharing.SharedLinkPolicy.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.Sharing.SharedLinkPolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedFolderChangeLinkPolicyDetails" />.</para>
        /// </summary>
        private class SharedFolderChangeLinkPolicyDetailsDecoder : enc.StructDecoder<SharedFolderChangeLinkPolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="SharedFolderChangeLinkPolicyDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedFolderChangeLinkPolicyDetails Create()
            {
                return new SharedFolderChangeLinkPolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedFolderChangeLinkPolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.Sharing.SharedLinkPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.Sharing.SharedLinkPolicy.Decoder.Decode(reader);
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
