/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */

namespace NPOI.HSSF.UserModel.helpers
{
    using System;

    using NPOI.HSSF.UserModel;
    using NPOI.HSSF.UserModel.Helpers;
    using NPOI.SS.Formula;
    using NPOI.SS.Formula.Eval;
    using NPOI.SS.UserModel;
    using NPOI.SS.UserModel.Helpers;
    using NPOI.Util;

    /**
     * Helper for Shifting rows up or down
     * 
     * When possible, code should be implemented in the RowShifter abstract class to avoid duplication with {@link NPOI.XSSF.UserModel.helpers.XSSFRowShifter}
     */
    public class HSSFRowShifter : RowShifter
    {
        private static POILogger logger = POILogFactory.GetLogger(typeof(HSSFRowShifter));

        public HSSFRowShifter(HSSFSheet sh)
                : base(sh)
        {
            ;
        }

        public override void UpdateNamedRanges(FormulaShifter Shifter)
        {
            throw new NotImplementedException("HSSFRowShifter.updateNamedRanges");
        }

        public override void UpdateFormulas(FormulaShifter Shifter)
        {
            throw new NotImplementedException("updateFormulas");
        }


        public override void UpdateRowFormulas(IRow row, FormulaShifter formulaShifter)
        {
            HSSFRowColShifter.UpdateRowFormulas(row, formulaShifter);
        }

        public override void UpdateConditionalFormatting(FormulaShifter Shifter)
        {
            throw new NotImplementedException("updateConditionalFormatting");
        }

        public override void UpdateHyperlinks(FormulaShifter Shifter)
        {
            throw new NotImplementedException("updateHyperlinks");
        }

    }

}