/*
This file is part of PacketDotNet

PacketDotNet is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

PacketDotNet is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with PacketDotNet.  If not, see <http://www.gnu.org/licenses/>.
*/
/*
 *  Copyright 2010 Evan Plaice <evanplaice@gmail.com>
 */

namespace PacketDotNet.Tcp
{
    /// <summary>
    /// SACK (Selective Ack) Permitted Option
    /// Notifies the receiver that SelectiveAcknowledgment is allowed.
    /// Must only be sent in a SYN segment
    /// </summary>
    /// <remarks>
    /// References:
    /// http://datatracker.ietf.org/doc/rfc2018/
    /// </remarks>
    public class SelectiveAcknowledgmentPermitted : Option
    {
        /// <summary>
        /// Creates a Sack Permitted Option
        /// </summary>
        /// <param name="bytes">
        /// A <see cref="T:System.Byte[]" />
        /// </param>
        /// <param name="offset">
        /// A <see cref="int" />
        /// </param>
        /// <param name="length">
        /// A <see cref="int" />
        /// </param>
        public SelectiveAcknowledgmentPermitted(byte[] bytes, int offset, int length) :
            base(bytes, offset, length)
        { }
    }
}