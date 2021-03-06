// Copyright (c) 2015 Alachisoft
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System;
using System.Text;

using Alachisoft.NCache.Web.Caching;
using System.IO;
using Alachisoft.NCache.Web.Communication;
using Alachisoft.NCache.Common.Protobuf.Util;
using Alachisoft.NCache.Web.Caching.Util;

namespace Alachisoft.NCache.Web.Command
{
    internal sealed class GetThresholdCommand : CommandBase
    {
        private Alachisoft.NCache.Common.Protobuf.GetThresholdSizeCommand _getThresholdCommand;

        internal GetThresholdCommand(bool isAsync)
        {
            base.name = "GetThresholdCommand";
            base.isAsync = isAsync;

            _getThresholdCommand = new Alachisoft.NCache.Common.Protobuf.GetThresholdSizeCommand();
            _getThresholdCommand.requestId = base.RequestId;
        }

        internal override CommandType CommandType
        {
            get { return CommandType.GET_THRESHOLD_SIZE; }
        }

        internal override RequestType CommandRequestType
        {
            get { return RequestType.InternalCommand; }
        }

        protected override void CreateCommand()
        {
            base._command = new Alachisoft.NCache.Common.Protobuf.Command();
            base._command.requestID = base.RequestId;
            base._command.getThresholdSizeCommand = _getThresholdCommand;
            base._command.type = Alachisoft.NCache.Common.Protobuf.Command.Type.GET_THRESHOLD_SIZE;

        }
    }
}
