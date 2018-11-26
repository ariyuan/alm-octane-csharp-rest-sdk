/*!
* (c) 2016-2018 EntIT Software LLC, a Micro Focus company
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/


using MicroFocus.Adm.Octane.Api.Core.Services.Attributes;

namespace MicroFocus.Adm.Octane.Api.Core.Entities
{
    /// <summary>
    /// Wrapper for TestSuiteLlinkToTest
    /// More fields might be supported by entity that still are not exposed in the class
    /// </summary>
    [CustomCollectionPath("test_suite_link_to_tests")]
    public class TestSuiteLlinkToTest : BaseEntity
    {
        public static string test_suite = "test_suite";
        public static string test = "test";

        public TestSuiteLlinkToTest()
        {
            AggregateType = "test_suite_link_to_test";
        }

        public TestSuiteLlinkToTest(EntityId id)
            : base(id)
        {
            AggregateType = "test_suite_link_to_test";
        }

        public string TestSuite
        {
            get
            {
                return GetStringValue(test_suite);
            }
            set
            {
                SetValue(test_suite, value);
            }
        }

        public string Test
        {
            get
            {
                return GetStringValue(test);
            }
            set
            {
                SetValue(test, value);
            }

        }
    }
}
