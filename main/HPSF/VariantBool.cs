/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) Under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You Under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed Under the License is distributed on an "AS Is" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations Under the License.
==================================================================== */
using NPOI.Util;

namespace NPOI.HPSF
{
    public class VariantBool
    {
        public const int SIZE = 2;
        private bool _value;

        public VariantBool(byte[] data, int offset)
        {
            short value = LittleEndian.GetShort(data, offset);
            switch (value)
            {
                case 0:
                    _value = false;
                    break;
                case -1:
                    _value = true;
                    break;
                default:
                    //logger.log(POILogger.WARN, "VARIANT_BOOL value '" + value + "' is incorrect");
                    _value = true;
                    break;
            }
        }
        public bool Value
        {
            get 
            {
                return _value;
            }
            set 
            {
                _value = value;
            }
        }
    }
}