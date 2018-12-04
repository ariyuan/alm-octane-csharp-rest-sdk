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


namespace MicroFocus.Adm.Octane.Api.Core.Entities
{
    /// <summary>
    /// Wrapper for Run Step entity
    /// More fields might be supported by entity that still are not exposed in the class
    /// </summary>
    public class RunStep : BaseEntity
    {
        public const string RESULT_FIELD = "result";
        public const string STEP_TYPE_FIELD = "step_type";
        public const string DESCRIPTION_FIELD = "description";
        public const string RUN_FIELD = "run";

        //public RunStep()
        //{
        //    AggregateType = "run";
        //}

        //public RunStep(EntityId id)
        //    : base(id)
        //{
        //    AggregateType = "run";
        //}

        public string Description
        {
            get
            {
                return GetStringValue(DESCRIPTION_FIELD);
            }
            set
            {
                SetValue(DESCRIPTION_FIELD, value);
            }

        }

        public BaseEntity Step_Type
        {
            get
            {
                return (BaseEntity)GetValue(STEP_TYPE_FIELD);
            }
            set
            {
                SetValue(STEP_TYPE_FIELD, value);
            }
        }

        public Run Run
        {
            get
            {
                return (Run)GetValue(RUN_FIELD);
            }
            set
            {
                SetValue(RUN_FIELD, value);
            }
        }

        public BaseEntity Status
        {
            get
            {
                return (BaseEntity)GetValue(RESULT_FIELD);
            }
            set
            {
                SetValue(RESULT_FIELD, value);
            }
        }
    }
}
