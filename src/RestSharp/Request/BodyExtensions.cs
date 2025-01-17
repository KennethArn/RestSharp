//  Copyright © 2009-2021 John Sheehan, Andrew Young, Alexey Zimarev and RestSharp community
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 

namespace RestSharp; 

static class BodyExtensions {
    public static bool TryGetBodyParameter(this RestRequest request, out Parameter? bodyParameter) {
        bodyParameter = request.Parameters.FirstOrDefault(p => p.Type == ParameterType.RequestBody);
        return bodyParameter != null;
    }

    public static Parameter[] GetPostParameters(this RestRequest request)
        => request.Parameters.Where(x => x.Type == ParameterType.GetOrPost).ToArray();

    public static bool HasPostParameters(this RestRequest request) => request.Parameters.Any(x => x.Type == ParameterType.GetOrPost);

    public static bool HasFiles(this RestRequest request) => request.Files.Count > 0;
}