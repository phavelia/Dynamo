using NUnit.Framework;
using ProtoCore.DSASM.Mirror;
using ProtoTestFx.TD;
namespace ProtoTest.TD.MultiLangTests
{
    [TestFixture]
    class TypeSystemTestsImperative
    {
        readonly TestFrameWork thisTest = new TestFrameWork();
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        [Category("Type System")]
        public void TS001_IntToDoubleTypeConversion_Imperative()
        {
            string code =
                @"a;b;[Imperative]{
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", 1);
            thisTest.Verify("b", 1.0);
        }

        [Test]
        [Category("Type System")]
        public void TS001a_DoubleToIntTypeConversion_Imperative()
        {
            string code =
                @"a;b;c;d;e;[Imperative]{a = 1.0;
            thisTest.RunScriptSource(code);
            //These should convert and emit warnings
            thisTest.Verify("a", 1.0);
            thisTest.Verify("b", 1);
            thisTest.Verify("c", 2);
            thisTest.Verify("d", 3);
            thisTest.Verify("e", 3);
        }

        [Test]
        [Category("Type System")]
        public void TS002_IntToUserDefinedTypeConversion_Imperative()
        {
            string code =
                @"
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", 1);
            thisTest.Verify("b", null);
        }

        [Test]
        [Category("Type System")]
        public void TS003IntToChar1467119_Imperative()
        {
            string code =
                @"y;[Imperative]{
            thisTest.RunScriptSource(code);
            thisTest.Verify("y", null);
            TestFrameWork.VerifyRuntimeWarning(ProtoCore.RuntimeData.WarningID.kMethodResolutionFailure);
        }

        [Test]
        [Category("Type System")]
        public void TS004_IntToChar_1467119_2_Imperative()
        {
            string code =
                @"y;
            thisTest.RunScriptSource(code);
            thisTest.Verify("y", true);
        }

        [Test]
        [Category("Type System")]
        public void TS005_RetTypeArray_return_Singleton_1467196_Imperative()
        {
            string code =
                @"
            //Assert.Fail("1467196 - Sprint 25 - Rev 3216 - [Design Issue] when rank of return type does not match the value returned what is the expected result ");
            thisTest.RunScriptSource(code);
            //thisTest.Verify("a",); not sure what is the expected behaviour 
        }

        [Test]
        [Category("Type System")]
        public void TS006_RetTypeuserdefinedArray_return_double_1467196_Imperative()
        {
            string code =
                @"
            //Assert.Fail("1467196 - Sprint 25 - Rev 3216 - [Design Issue] when rank of return type does not match the value returned what is the expected result ");
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", null);
            //thisTest.Verify("a",); not sure what is the expected behaviour 
        }

        [Test]
        [Category("Type System")]
        public void TS007_Return_double_To_int_1467196_Imperative()
        {
            string code =
                @" class A
            //Assert.Fail("1467196 - Sprint 25 - Rev 3216 - [Design Issue] when rank of return type does not match the value returned what is the expected result ");
            thisTest.RunScriptSource(code);
            thisTest.Verify("numpts", 1);
            thisTest.Verify("a", null);
        }

        [Test]
        [Category("Type System")]
        public void TS008_Param_Int_IntArray_1467208_Imperative()
        {
            string code =
                @"r;[Imperative]{
            string error = "DNL-1467208 Auto-upcasting of int -> int[] is not happening in some cases";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("r", new object[] { 1 });
        }

        [Test]
        [Category("Type System")]
        public void TS009_Parameter_Int_ToBoolArray_1467182_Imperative()
        {
            string code =
                @"r;[Imperative]{
            //Assert.Fail("1467182 - Sprint 25 - [Design Decision] Rev 3163 - method resolution or type conversion is expected in following cases ");
            thisTest.RunScriptSource(code);
            thisTest.Verify("r", 1);
            // not sure about the expected behaviour - add verification once solve design issue
        }

        [Test]
        [Category("Type System")]
        public void TS010_Parameter_Bool_ToIntArray_1467182_Imperative()
        {
            string code =
                @"r;[Imperative]{
            thisTest.RunScriptSource(code);
            thisTest.Verify("r", null);
        }

        [Test]
        [Category("Type System")]
        public void TS011_Return_Int_ToIntArray_Imperative()
        {
            string code =
                @"r;[Imperative]{
            //Assert.Fail("1467200 - Sprint 25 - rev 3242 type checking negative cases failing ");
            thisTest.RunScriptSource(code);
            thisTest.Verify("r", new object[] { 3 });
        }

        [Test]
        [Category("Type System")]
        public void TS012_Return_Int_ToBoolArray_1467182_Imperative()
        {
            string code =
                @"r;[Imperative]{
            //Assert.Fail("1467182 - Sprint 25 - [Design Decision] Rev 3163 - method resolution or type conversion is expected in following cases  ");
            thisTest.RunScriptSource(code);
            thisTest.Verify("r", null);
        }

        [Test]
        [Category("Type System")]
        public void TS013_Parameter_Bool_ToIntArray_Imperative()
        {
            string code =
                @"r;[Imperative]{
            //Assert.Fail("1467200 - Sprint 25 - rev 3242 type checking negative cases failing ");
            thisTest.RunScriptSource(code);
            thisTest.Verify("r", null);
        }

        [Test]
        [Category("Type System")]
        public void TS014_Return_IntArray_ToInt_Imperative()
        {
            string code =
                @"r;[Imperative]{
            //Assert.Fail("1467200 - Sprint 25 - rev 3242 type checking negative cases failing ");
            thisTest.RunScriptSource(code);
            thisTest.Verify("r", null);
        }

        [Test]
        [Category("Type System")]
        public void TS015_Parameter_BoolArray_ToInt_Imperative()
        {
            string code =
                @"r;[Imperative]{
            //Assert.Fail("1467200 - Sprint 25 - rev 3242 type checking negative cases failing ");
            thisTest.RunScriptSource(code);
            thisTest.Verify("r", null);
        }

        [Test]
        [Category("Type System")]
        public void TS016_Return_BoolArray_ToInt_Imperative()
        {
            string code =
                @"r;[Imperative]{
            //Assert.Fail("1467200 - Sprint 25 - rev 3242 type checking negative cases failing ");
            thisTest.RunScriptSource(code);
            thisTest.Verify("r", null);
        }

        [Test]
        [Category("Type System")]
        public void TS017_Return_BoolArray_ToInt_1467182_Imperative()
        {
            string code =
                @"          class A
            string error = "1467182 - Sprint 25 - [Design Decision] Rev 3163 - method resolution or type conversion is expected in following cases ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("c", null);// null 
        }

        [Test]
        [Category("Type System")]
        public void TS018_Param_Int_ordouble_ToBool_1467172_Imperative()
        {
            string code =
                @"
            //Assert.Fail("1467172 - sprint 25 - Rev 3146 - [Design Issue ] the type conversion between int/double to bool not allowed ");
            thisTest.RunScriptSource(code);
            thisTest.Verify("b", new object[] { true });
            thisTest.Verify("c", new object[] { true });
            thisTest.Verify("d", 3);
        }

        [Test]
        [Category("Type System")]
        public void TS018_Return_Int_ordouble_ToBool_1467172_2_Imperative()
        {
            string code =
                @"
            //Assert.Fail("1467172 - sprint 25 - Rev 3146 - [Design Issue ] the type conversion between int/double to bool not allowed ");
            thisTest.RunScriptSource(code);
            thisTest.Verify("b", true);
            thisTest.Verify("c", true);
            thisTest.Verify("d", 3);
        }

        [Test]
        [Category("Type System")]
        public void TS019_conditional_cantevaluate_1467170_Imperative()
        {
            string code =
                @"
            thisTest.RunScriptSource(code);
            thisTest.Verify("A", 3);
        }

        [Test]
        [Category("Type System")]
        public void TS020_conditional_cantevaluate_1467170_Imperative()
        {
            string code =
                @"
            thisTest.RunScriptSource(code);
            thisTest.Verify("A", 2);
        }

        [Test]
        [Category("Type System")]
        public void TS021_OverallPrimitiveConversionTestInt_Imperative()
        {
            string code =
                @"class A {}
            thisTest.RunScriptSource(code);
            thisTest.Verify("zero_var", 0);
            thisTest.Verify("zero_int", 0);
            thisTest.Verify("zero_double", 0.0);
            thisTest.Verify("zero_bool", false);
            thisTest.Verify("zero_String", null);
            thisTest.Verify("zero_char", null);
            thisTest.Verify("zero_a", null);
            thisTest.Verify("one_var", 1);
            thisTest.Verify("one_int", 1);
            thisTest.Verify("one_double", 1.0);
            thisTest.Verify("one_bool", true);
            thisTest.Verify("one_String", null);
            thisTest.Verify("one_char", null);
            thisTest.Verify("one_a", null);
            thisTest.Verify("foo", 32);
            thisTest.Verify("foo2", 33);
            thisTest.Verify("foo3", 33);
        }

        [Test]
        [Category("Type System")]
        public void TS022_conditional_cantevaluate_1467170_Imperative()
        {
            string code =
                @"A;
            thisTest.RunScriptSource(code);
            thisTest.Verify("A", 3);
        }

        [Test]
        [Category("Type System")]
        public void TS023_Double_To_Int_1467084_Imperative()
        {
            string code =
                @"x;[Imperative]{
            //Assert.Fail("1463268 - Sprint 20 : [Design Issue] Rev 1822 : Method resolution fails when implicit type conversion of double to int is expected ");
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 3);
        }

        [Test]
        [Category("Type System")]
        public void TS023_Double_To_Int_1467084_2_Imperative()
        {
            string code =
                @"t;[Imperative]{
            //Assert.Fail("1463268 - Sprint 20 : [Design Issue] Rev 1822 : Method resolution fails when implicit type conversion of double to int is expected ");
            thisTest.RunScriptSource(code);
            thisTest.Verify("t", 3);
        }

        [Test]
        [Category("Type System")]
        public void TS023_Double_To_Int_1467084_3_Imperative()
        {
            string code =
                @"class twice
            //Assert.Fail("1463268 - Sprint 20 : [Design Issue] Rev 1822 : Method resolution fails when implicit type conversion of double to int is expected ");
            thisTest.RunScriptSource(code);
            thisTest.Verify("d", new object[] { null, null });
        }

        [Test]
        [Category("Type System")]
        public void TS024_Double_To_Int_IndexIntoArray_1467214_Imperative()
        {
            string code =
                @"b;[Imperative]{
            //     Assert.Fail("1467214 - Sprint 26- Rev 3313 Type Conversion from Double to Int not happening while indexing into array ");
            thisTest.RunScriptSource(code);
            thisTest.Verify("b", 4);
        }

        [Test]
        [Category("Type System")]
        public void TS025_KeyWords_Doesnotexist_1467215_Imperative()
        {
            string code =
                @"a;[Imperative]{
            string error = "1467215 - Sprint 26 - rev 3310 language is too easy on key words for typesystem , even when does not exist it passes  ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", null);
        }

        [Test]
        [Category("Type System")]
        public void TS026_Double_ToInt_1467211_Imperative()
        {
            string code =
                @"a;[Imperative]{
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", 4);
        }

        [Test]
        [Category("Type System")]
        public void TS027_Double_ToInt_1467217_Imperative()
        {
            string code =
                @"a;[Imperative]{
            //Assert.Fail("1467217 - Sprint 26 - Rev 3337 - Type Conversion does not happen if the function returns an array ");
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", new object[] { 4 });
        }

        [Test]
        [Category("Type System")]
        public void TS028_Double_ToInt_1467218_Imperative()
        {
            string code =
                @"a;[Imperative]{
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", 4);
        }

        [Test]
        [Category("Type System")]
        public void TS028_Double_ToInt_1467218_1_Imperative()
        {
            string code =
                @"a;[Imperative]{
            //Assert.Fail("1467218 - Sprint 26 - Rev 3337 - Type Conversion does not happen if the function returns and array and and index into function call ");
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", 4);
        }

        [Test]
        [Category("Type System")]
        public void TS029_Double_ToVar_1467222_Imperative()
        {
            string code =
                @"class A
            //Assert.Fail("1467222 - Sprint 26 - rev 3345 - if return type is var it still does type conversion ");
            thisTest.RunScriptSource(code);
            thisTest.Verify("b", 4);
        }

        [Test]
        [Category("Type System")]
        public void TS029_Double_ToInt_1463268_Imperative()
        {
            string code =
                @"t;[Imperative]{
            //Assert.Fail("1463268 - Sprint 20 : [Design Issue] Rev 1822 : Method resolution fails when implicit type conversion of double to int is expected");
            thisTest.RunScriptSource(code);
            thisTest.Verify("t", 3);
        }

        [Test]
        [Category("Type System")]
        public void TS030_eachtype_To_var_Imperative()
        {
            string code =
                @"class A{ a=1; }
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", 1.5);
            thisTest.Verify("b", 1);
            thisTest.Verify("c", "1.5");
            thisTest.Verify("d1", 1);
            thisTest.Verify("e", false);
            thisTest.Verify("f", null);
        }

        [Test]
        [Category("Type System")]
        public void TS031_eachType_To_int_Imperative()
        {
            string code =
                @" class A{ a=1; }
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", 2);
            thisTest.Verify("b", 1);
            thisTest.Verify("c", null);
            thisTest.Verify("d1", null);
            thisTest.Verify("e", null);
            thisTest.Verify("f", null);
        }

        [Test]
        [Category("Type System")]
        public void TS031_eachtype_To_double_Imperative()
        {
            string code =
                @" class A{ a=1; }
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", 1.0);
            thisTest.Verify("b", 1.0);
            thisTest.Verify("c", null);
            thisTest.Verify("d1", null);
            thisTest.Verify("e", null);
            thisTest.Verify("f", null);
        }

        [Test]
        [Category("Type System")]
        public void TS032_eachType_To_bool_Imperative()
        {
            string code =
                @"class A{ a=1; }
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", true);
            thisTest.Verify("b", true);
            thisTest.Verify("c", true);
            thisTest.Verify("c1", false);
            thisTest.Verify("d", true);
            thisTest.Verify("e", true);
            thisTest.Verify("e1", null);
        }

        [Test]
        [Category("Type System")]
        public void TS033_eachType_To_string_Imperative()
        {
            string code =
                @"class A{ a=1; }
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", null);
            thisTest.Verify("b", null);
            thisTest.Verify("c", "1.5");
            thisTest.Verify("d1", null);
            //   thisTest.Verify("c1", "1");//Assert.Fail("1467227 -Sprint 26 - 3329 char not convertible to string ");
            thisTest.Verify("e", null);
            thisTest.Verify("f", null);
        }

        [Test]
        [Category("Type System")]
        public void TS034_eachType_To_char_Imperative()
        {
            string code =
                @"class A{ a=1; }
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", null);
            thisTest.Verify("b", null);
            thisTest.Verify("c", null);
            thisTest.Verify("d1", null);
            thisTest.Verify("c1", '1');
            thisTest.Verify("e", null);
            thisTest.Verify("f", null);
        }

        [Test]
        [Category("Type System")]
        public void TS34_CharToString_1467227_Imperative()
        {
            string code =
               @"a;[Imperative]{
            thisTest.RunScriptSource(code, "1467227 -Sprint 26 - 3329 char not convertible to string ");
            thisTest.Verify("a", "1");
        }

        [Test]
        [Category("Type System")]
        public void TS35_nullTobool_1467231_Imperative()
        {
            string code =
                @"a;[Imperative]{
            thisTest.RunScriptSource(code);
            //Assert.Fail("1467231 - Sprint 26 - Rev 3393 null to bool conversion should not be allowed ");
            thisTest.Verify("a", null);
        }

        [Test]
        [Category("Type System")]
        public void TS36_stringTobool_1467239_Imperative()
        {
            string code =
                @"c;c1;[Imperative]{
            thisTest.RunScriptSource(code);
            //Assert.Fail("1467239 - Sprint 26 - Rev 3425 type conversion - string to bool conversion failing  ");
            thisTest.Verify("c", true);
            thisTest.Verify("c1", false);
        }

        [Test]
        [Category("Type System")]
        public void TS37_userdefinedTobool_1467240_Imperative()
        {
            string code =
                @"class A
            string error = "1467287 Sprint 26 - 3721 user defined to bool conversion does not happen in imperative ";
            thisTest.RunScriptSource(code, error);
            //Assert.Fail("1467240 - Sprint 26 - Rev 3426 user defined type not convertible to bool");
            thisTest.Verify("d", true);
        }

        [Test]
        [Category("Type System")]
        public void TS038_eachType_To_Userdefined_Imperative()
        {
            string code =
                @"          class B{ b=1; }
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", null);
            thisTest.Verify("b", null);
            thisTest.Verify("c", null);
            thisTest.Verify("d", null);
            thisTest.Verify("e1", 1);
            thisTest.Verify("f", null);
            thisTest.Verify("g", null);
        }

        [Test]
        [Category("Type System")]
        public void TS039_userdefined_covariance_Imperative()
        {
            string code =
                @"class A
            thisTest.RunScriptSource(code);
            thisTest.Verify("a1", 1);
            thisTest.Verify("b1", 2);
            thisTest.Verify("b2", 0);
            thisTest.Verify("c", null);
            thisTest.Verify("c1", null);
            thisTest.Verify("c2", null);
        }

        [Test]
        [Category("Type System")]
        public void TS40_null_toBool_1467231_Imperative()
        {
            string code =
                @"a;[Imperative]{
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", null);
        }

        [Test]
        [Category("Type System")]
        public void TS41_null_toBool_1467231_2_Imperative()
        {
            string code =
                @"a;c;[Imperative]{
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", null);
            thisTest.Verify("c", null);
        }

        [Test]
        [Category("Type System")]
        public void TS42_null_toBool_1467231_3_Imperative()
        {
            string code =
                @"c;[Imperative]{
            thisTest.RunScriptSource(code);
            thisTest.Verify("c", null);
        }

        [Test]
        [Category("Type System")]
        public void TS43_null_toBool_1467231_positive_Imperative()
        {
            string code =
                @"b;
            thisTest.RunScriptSource(code);
            thisTest.Verify("b", 2);
        }

        [Test]
        [Category("Type System")]
        public void TS44_any_toNull_Imperative()
        {
            string code =
                @"class test
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", null);
            thisTest.Verify("b", null);
            thisTest.Verify("c", null);
            thisTest.Verify("d", null);
            thisTest.Verify("e", null);
            thisTest.Verify("f", null);
            thisTest.Verify("g", null);
        }

        [Test]
        [Category("Type System")]
        public void TS45_int_To_Double_1463268_Imperative()
        {
            string code =
                @"t;[Imperative]{
            thisTest.RunScriptSource(code);
            thisTest.Verify("t", 3);
        }

        [Test]
        [Category("Type System")]
        public void TS46_typedassignment_To_array_1467206_Imperative()
        {
            string code =
                @" class test
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", new object[] { 1.0, 2.0, 3.0 });
            thisTest.Verify("b", new object[] { 1, 2, 3 });
            thisTest.Verify("c", new object[] { "a", "b", "c" });
            thisTest.Verify("d", new object[] { 'c', 'd', 'e' });
            thisTest.Verify("e1", new object[] { null, null, null });
            thisTest.Verify("f", new object[] { true, false, null });
            thisTest.Verify("g", new object[] { null, null, null });
        }

        [Test]
        [Category("Type System")]
        public void TS46_typedassignment_To_array_1467294_2()
        {
            string code =
                @"

            string error = "1467294 =Sprint 26 - Rev 3763 - in typed assignment, array promotion does not occur in some cases";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", new object[] { 1.0 });
            thisTest.Verify("b", new object[] { 1 });
            thisTest.Verify("c", new object[] { "a" });
            thisTest.Verify("d", new object[] { 'c' });
            thisTest.Verify("e1", new object[] { 1 });
            thisTest.Verify("f", new object[] { true });
            thisTest.Verify("g", new object[] { null });
        }

        [Test]
        [Category("Type System")]
        public void TS46_typedassignment_To_array_1467294_3()
        {
            string code =
                @"

            string error = "1467294 =Sprint 26 - Rev 3763 - in typed assignment, array promotion does not occur in some cases";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", new object[] { new object[] { 1.0 } });
            thisTest.Verify("b", new object[] { new object[] { 1 } });
            thisTest.Verify("c", new object[] { new object[] { "a" } });
            thisTest.Verify("d", new object[] { new object[] { 'c' } });
            thisTest.Verify("e1", new object[] { new object[] { 1 } });
            thisTest.Verify("f", new object[] { new object[] { true } });
            thisTest.Verify("g", new object[] { new object[] { null } });
        }

        [Test]
        [Category("Type System")]
        public void TS46_typedassignment_To_Vararray_1467294_4()
        {
            string code =
                @"
            string error = "1467294 =Sprint 26 - Rev 3763 - in typed assignment, array promotion does not occur in some cases";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", new object[] { new object[] { 1.0 } });
            thisTest.Verify("b", new object[] { new object[] { 1 } });
            thisTest.Verify("c", new object[] { new object[] { "a" } });
            thisTest.Verify("d", new object[] { new object[] { 'c' } });
            thisTest.Verify("e1", new object[] { new object[] { 1 } });
            thisTest.Verify("f", new object[] { new object[] { true } });
            thisTest.Verify("g", new object[] { new object[] { null } });
        }

        [Test]
        [Category("Type System")]
        public void TS047_double_To_Int_insidefunction_Imperative()
        {
            string code =
                @"t;
            //thisTest.SetErrorMessage("1467250 Sprint 26 - 3472 - variable modification inside a function does not follow type conversion rules ");
            string error = "1467250 - Sprint 26 - 3472 - variable modification inside a function does not follow type conversion rules ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("t", 4);
        }

        [Test]
        [Category("Type System")]
        public void TS047_double_To_Int_insidefunction_2_Imperative()
        {
            string code =
                @"t;[Imperative]{
            //thisTest.SetErrorMessage("1467250 Sprint 26 - 3472 - variable modification inside a function does not follow type conversion rules ");
            string error = "1467250 - Sprint 26 - 3472 - variable modification inside a function does not follow type conversion rules ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("t", 10.5);
        }

        [Test]
        [Category("Type System")]
        public void TS048_Param_eachType_To_varArray_Imperative()
        {
            string code =
                @"class A{ a=1; }
            string error = "1467251 - sprint 26 - Rev 3485 type conversion from var to var array promotion is not happening ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", new object[] { 1.5 });
            thisTest.Verify("b", new object[] { 1 });
            thisTest.Verify("c", new object[] { "1.5" });
            thisTest.Verify("d1", new object[] { 1 });
            thisTest.Verify("e", new object[] { false });
            thisTest.Verify("f", new object[] { null });
        }

        [Test]
        [Category("Type System")]
        public void TS049_Return_eachType_To_varArray_Imperative()
        {
            string code =
                @"class A{ a=1; }
            string error = "1467251 - sprint 26 - Rev 3485 type conversion from var to var array promotion is not happening ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", new object[] { 1.5 });
            thisTest.Verify("b", new object[] { 1 });
            thisTest.Verify("c", new object[] { "1.5" });
            thisTest.Verify("d1", new object[] { 1 });
            thisTest.Verify("e", new object[] { false });
            thisTest.Verify("f", new object[] { null });
        }

        [Test]
        [Category("Type System")]
        public void TS050_Return_eachType_To_intArray_Imperative()
        {
            //  
            string code =
                @" class A{ a=1; }
            string error = "1467251 - sprint 26 - Rev 3485 type conversion from var to var array promotion is not happening ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", new object[] { 2 });
            thisTest.Verify("a1", new object[] { 2 });
            thisTest.Verify("b", new object[] { 1 });
            thisTest.Verify("c", null);
            thisTest.Verify("d1", null);
            thisTest.Verify("e", null);
            thisTest.Verify("f", null);
        }

        [Test]
        [Category("Type System")]
        public void TS051_Param_eachType_To_intArray_Imperative()
        {
            string code =
                @"class A{ a=1; }
            string error = "1467251 - sprint 26 - Rev 3485 type conversion from var to var array promotion is not happening ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", new object[] { 2 });
            thisTest.Verify("a1", new object[] { 2 });
            thisTest.Verify("b", new object[] { 1 });
            thisTest.Verify("c", null);
            thisTest.Verify("d1", null);
            thisTest.Verify("e", null);
            thisTest.Verify("f", null);
        }

        [Test]
        [Category("Type System")]
        public void TS052_Return_AllTypeTo_doubleArray_Imperative()
        {
            //  
            string code =
                @"class A{ a=1; }
            string error = "1467251 - sprint 26 - Rev 3485 type conversion from var to var array promotion is not happening ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", new object[] { 1.5 });
            thisTest.Verify("a1", new object[] { 1.5 });
            thisTest.Verify("b", new object[] { 1.0 });
            thisTest.Verify("c", null);
            thisTest.Verify("d1", null);
            thisTest.Verify("e", null);
            thisTest.Verify("f", null);
        }

        [Test]
        [Category("Type System")]
        public void TS053_Param_AlltypeTo_doubleArray_Imperative()
        {
            //  
            string code =
                @"class A{ a=1; }
            string error = "1467251 - sprint 26 - Rev 3485 type conversion from var to var array promotion is not happening ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", new object[] { 1.5 });
            thisTest.Verify("a", new object[] { 1.5 });
            thisTest.Verify("b", new object[] { 1.0 });
            thisTest.Verify("c", null);
            thisTest.Verify("d1", null);
            thisTest.Verify("e", null);
            thisTest.Verify("f", null);
        }

        [Test]
        [Category("Type System")]
        public void TS055_Param_AlltypeTo_BoolArray_Imperative()
        {
            string code =
                @"class A{ a=1; }
            string error = "1467251 - sprint 26 - Rev 3485 type conversion from var to var array promotion is not happening ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", new object[] { true, true });
            thisTest.Verify("a1", new object[] { true, true });
            thisTest.Verify("b", new object[] { true, false });
            thisTest.Verify("c", new object[] { true, false });
            thisTest.Verify("c", new object[] { true, false });
            thisTest.Verify("d", new object[] { true, true });
            thisTest.Verify("e", new object[] { false, true });
            thisTest.Verify("e1", null);
        }

        [Test]
        [Category("Type System")]
        public void TS056_Return_AlltypeTo_BoolArray_Imperative()
        {
            string code =
                @"class A{ a=1; }
            string error = "1467251 - sprint 26 - Rev 3485 type conversion from var to var array promotion is not happening ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", new object[] { true, true });
            thisTest.Verify("a1", new object[] { true, true });
            thisTest.Verify("b", new object[] { true, false });
            thisTest.Verify("c", new object[] { true, false });
            thisTest.Verify("d", new object[] { true, true });
            thisTest.Verify("e", new object[] { true, true });
            thisTest.Verify("f", new object[] { false, true });
            thisTest.Verify("g", new object[] { null, null});
        }

        [Test]
        [Category("Type System")]
        public void TS056_Return_BoolArray_1467258_Imperative()
        {
            string code =
                @"class A{ a=1; }
            string error = "1467258 - sprint 26 - Rev 3541 if the return type is bool array , type conversion does not happen for some cases  ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", new object[] { new object[] { true }, new object[] { true } });
            thisTest.Verify("a1", null);
            thisTest.Verify("b", new object[] { new object[] { true }, new object[] { false } });
            thisTest.Verify("c", new object[] { new object[] { true }, new object[] { false } });
            thisTest.Verify("d", new object[] { new object[] { true }, new object[] { false } });
            thisTest.Verify("e", new object[] { new object[] { true }, new object[] { true } });
        }

        [Test]
        [Category("Type System")]
        public void TS058_setter_Typeconversion_1467262_Imperative()
        {
            string code =
                @"class A
            string error = "1467262 - Sprint 26 - Rev 3543 , setter method does not do type conversion correctly";
            ExecutionMirror mirror = thisTest.RunScriptSource(code, error);
            thisTest.VerifyProperty(mirror, "a", "id", null, 0);
        }

        [Test]
        [Category("Type System")]
        public void TS059Double_To_int_1467203_Imperative()
        {
            string code =
                @"a;[Imperative]{
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", 3);
        }

        [Test]
        [Category("Type System")]
        public void TS060Double_To_int_1467203_Imperative()
        {
            string code =
                @"a;[Imperative]{
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", 3);
        }

        [Test]
        [Category("Type System")]
        public void TS061_typeconersion_imperative_1467213_Imperative()
        {
            string code =
                @"a;[Imperative]
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", 3);
        }

        [Test]
        [Category("Type System")]
        public void TS062_basic_upcoerce_assign_Imperative()
        {
            string code =
                @"
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", new object[] { 3 });
        }

        [Test]
        [Category("Type System")]
        public void TS063_basic_upcoerce_dispatch_Imperative()
        {
            string code =
                @"a;
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", new object[] { 3 });
        }

        [Test]
        [Category("Type System")]
        public void TS063_basic_upcoerce_return_Imperative()
        {
            string code =
                @"a;
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", new object[] { 3 });
        }

        [Test]
        [Category("Type System")]
        public void TS064_bool_Conditionals_1467278_Imperative()
        {
            string code =
                @"
            string error = "1467278 - Sprint 26 - Rev 3667 - type conversion fails when evaluating boolean conditionals ";
            ExecutionMirror mirror = thisTest.RunScriptSource(code, error);
            thisTest.Verify("x", true);
            thisTest.Verify("y", false);
        }

        [Test]
        [Category("Type System")]
        public void TS065_doubleToInt_IndexingIntoArray_1467214_Imperative()
        {
            string code =
                @"b;c;d;[Imperative]{
            string error = "1467214 - Sprint 26- Rev 3313 Type Conversion from Double to Int not happening while indexing into array ";
            ExecutionMirror mirror = thisTest.RunScriptSource(code, error);
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("b", 4);
            thisTest.Verify("c", 3);
            thisTest.Verify("d", 4);

        }


        [Test]
        [Category("Type System")]
        public void TS065_doubleToInt_IndexingIntoArray_1467214_2_Imperative()
        {
            string code =
                @"b;[Imperative]{
            string error = "1467214 - Sprint 26- Rev 3313 Type Conversion from Double to Int not happening while indexing into array ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("b", 2);
        }

        [Test]
        [Category("Type System")]
        public void TS066_Int_To_Char_1467119_Imperative()
        {
            string code =
                @"y;[Imperative]{
            string error = "1467119 - Sprint24 : rev 2807 : Type conversion issue with char  ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("y", null);
        }

        [Test]
        [Category("Type System")]
        public void TS067_string_To_Char_1467119_2_Imperative()
        {
            string code =
                @"y;[Imperative]{
            string error = "1467119 - Sprint24 : rev 2807 : Type conversion issue with char  ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("y", null);
        }

        [Test]
        [Category("Type System")]
        public void TS068_Param_singleton_AlltypeTo_BoolArray_Imperative()
        {
            string code =
                @"class A{ a=1; }
            string error = "1467251 - sprint 26 - Rev 3485 type conversion from var to var array promotion is not happening ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", new object[] { true });
            thisTest.Verify("a1", new object[] { true });
            thisTest.Verify("b", new object[] { true });
            thisTest.Verify("c", new object[] { true });
            thisTest.Verify("c", new object[] { true });
            thisTest.Verify("d", new object[] { true });
            thisTest.Verify("e", new object[] { false });
            thisTest.Verify("e1", null);
        }

        [Test]
        [Category("Type System")]
        public void TS069_Return_singleton_AlltypeTo_BoolArray_Imperative()
        {
            string code =
                @"class A{ a=1; }
            string error = "1467251 - sprint 26 - Rev 3485 type conversion from var to var array promotion is not happening ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", new object[] { true });
            thisTest.Verify("a1", new object[] { true });
            thisTest.Verify("b", new object[] { true });
            thisTest.Verify("c", new object[] { true });
            thisTest.Verify("c1", new object[] { true });
            thisTest.Verify("d", new object[] { true });
            thisTest.Verify("e", new object[] { false });
            thisTest.Verify("e1", null);
        }

        [Test]
        [Category("Type System")]
        public void TS070_Param_singleton_AlltypeTo_StringArray_Imperative()
        {
            string code =
                @" class A{ a=1; }
            string error = "1467251 - sprint 26 - Rev 3485 type conversion from var to var array promotion is not happening ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", null);
            thisTest.Verify("a1", null);
            thisTest.Verify("b", null);
            thisTest.Verify("c", new object[] { "1.5" });
            thisTest.Verify("c1", new object[] { "1" });
            thisTest.Verify("d", null);
            thisTest.Verify("e", null);
            thisTest.Verify("e1", null);
        }

        [Test]
        [Category("Type System")]
        public void TS071_return_singleton_AlltypeTo_StringArray_Imperative()
        {
            string code =
                @"class A{ a=1; }
            string error = "1467251 - sprint 26 - Rev 3485 type conversion from var to var array promotion is not happening ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", null);
            thisTest.Verify("a1", null);
            thisTest.Verify("b", null);
            thisTest.Verify("c", new object[] { "1.5" });
            thisTest.Verify("c1", new object[] { "1" });
            thisTest.Verify("d", null);
            thisTest.Verify("e", null);
            thisTest.Verify("f", null);
        }

        [Test]
        [Category("Type System")]
        public void TS072_Param_singleton_AlltypeTo_CharArray_Imperative()
        {
            string code =
                @" class A{ a=1; }
            string error = "1467251 - sprint 26 - Rev 3485 type conversion from var to var array promotion is not happening ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", null);
            thisTest.Verify("a1", null);
            thisTest.Verify("b", null);
            thisTest.Verify("c", null);
            thisTest.Verify("c1", new object[] { '1' });
            thisTest.Verify("d", null);
            thisTest.Verify("e", null);
            thisTest.Verify("f", null);
        }

        [Test]
        [Category("Type System")]
        public void TS073_return_singleton_AlltypeTo_CharArray_Imperative()
        {
            string code =
                @"class A{ a=1; }
            string error = "1467251 - sprint 26 - Rev 3485 type conversion from var to var array promotion is not happening ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", null);
            thisTest.Verify("a1", null);
            thisTest.Verify("b", null);
            thisTest.Verify("c", null);
            thisTest.Verify("c1", new object[] { '1' });
            thisTest.Verify("d", null);
            thisTest.Verify("e", null);
            thisTest.Verify("f", null);
        }

        [Test]
        [Category("Type System")]
        public void TS074_Param_singleton_AlltypeTo_UserDefinedArray_Imperative()
        {
            string code =
                @"      class A{ a=1; }
            string error = "1467251 - sprint 26 - Rev 3485 type conversion from var to var array promotion is not happening ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", null);
            thisTest.Verify("a1", null);
            thisTest.Verify("b", null);
            thisTest.Verify("c", null);
            thisTest.Verify("c1", null);
            thisTest.Verify("d1", new object[] { 2 });
            thisTest.Verify("e", null);
            thisTest.Verify("f", null);
            thisTest.Verify("g", null);
        }

        [Test]
        [Category("Type System")]
        public void TS075_return_singleton_AlltypeTo_UserDefinedArray_Imperative()
        {
            string code =
                @"class B{ b = 2.0; }
            string error = "1467251 - sprint 26 - Rev 3485 type conversion from var to var array promotion is not happening ";
            thisTest.RunScriptSource(code, error);
            thisTest.Verify("a", null);
            thisTest.Verify("a1", null);
            thisTest.Verify("b", null);
            thisTest.Verify("c", null);
            thisTest.Verify("c1", null);
            thisTest.Verify("d1", new object[] { 2 });
            thisTest.Verify("e", null);
            thisTest.Verify("f", null);
            thisTest.Verify("g", null);
        }
        /* 
[Test]

        [Test]
        [Category("Type System")]
        public void TS078_userdefinedToUserdefinedArray_Imperative()
        {
            string code =
                @"class A

            string error = " ";
            thisTest.RunScriptSource(code, error);
            //Assert.Fail("1467240 - Sprint 26 - Rev 3426 user defined type not convertible to bool");
            thisTest.Verify("a1", new object[] { 1 });
        }

        [Test]
        public void indexintoarray_left_1467462_1_imperative()
        {
            string code =
                @"x;
            var mirror = thisTest.RunScriptSource(code);
            TestFrameWork.Verify(mirror, "x", new object[] { 1, 2, 1, 2 });
        }

        [Test]
        public void indexintoarray_left_1467462_2_imperative()
        {
            string code =
                @"x;
            var mirror = thisTest.RunScriptSource(code);
            TestFrameWork.Verify(mirror, "x", new object[] { 1, 2, 1, 2 });
        }

        [Test]
        public void indexintoarray_left_1467462_3_imperative()
        {
            string code =
                @"x;
            var mirror = thisTest.RunScriptSource(code);
            TestFrameWork.Verify(mirror, "x", new object[] { 1, 2, 1, 2 });
        }

        [Test]
        public void indexintoarray_left_1467462_4_imperative()
        {
            string code =
                @"x;
            var mirror = thisTest.RunScriptSource(code);
            TestFrameWork.Verify(mirror, "x", new object[] { true, false, true, true });
        }

        [Test]
        public void indexintoarray_left_1467462_5_imperative()
        {
            string code =
                @"x;
            var mirror = thisTest.RunScriptSource(code);
            TestFrameWork.Verify(mirror, "x", new object[] { 1, false, true, 2 });
        }

        [Test]
        public void indexintoarray_left_1467462_6_imperative()
        {
            string code =
                @"
            var mirror = thisTest.RunScriptSource(code);
            TestFrameWork.Verify(mirror, "x", new object[] { 1, 1, 2, 2 });
        }

        [Test]
        public void indexintoarray_left_1467462_7_imperative()
        {
            string code =
                @"
            var mirror = thisTest.RunScriptSource(code);
            TestFrameWork.Verify(mirror, "y", new object[] { 1, 1, null, null });
        }

        [Test]
        [Category("Type System")]
        public void TS0189_TypeConversion_conditionals_1465293_1_imperative()
        {
            string code =
                @"
            string error = " ";
            var mirror = thisTest.RunScriptSource(code, error);
            TestFrameWork.Verify(mirror, "a", false);
            TestFrameWork.Verify(mirror, "b", true);
            TestFrameWork.Verify(mirror, "c", true);
            TestFrameWork.Verify(mirror, "d", false);
        }

        [Test]
        [Category("Type System")]
        public void TS0189_TypeConversion_class_member_1467599()
        {
            string code =
                @"
            string error = " ";
            var mirror = thisTest.RunScriptSource(code, error);
            //TestFrameWork.VerifyRuntimeWarning(ProtoCore.RuntimeData.WarningID.kTypeMismatch);
            thisTest.VerifyRuntimeWarningCount(1);
            thisTest.Verify("b", null);
        }

        [Test]
        [Category("Type System")]
        public void TS0190_TypeConversion_nested_block_1467568()
        {
            string code =
                @"
            string error = " ";
            var mirror = thisTest.RunScriptSource(code, error);
            thisTest.Verify("c", 16.5);
        }

        [Test]
        [Category("Type System")]
        public void TS0191_TypeConversion_nested_block_1467568()
        {
            string code =
                @"
            string error = " ";
            var mirror = thisTest.RunScriptSource(code, error);
            thisTest.Verify("myRangeExpressionResult", new object[] { 0.0, 449.99999999999983, 899.99999999999966, 1349.9999999999995, 1799.9999999999993 });
        }

        [Test]
        [Category("Type System")]
        public void TS0192_TypeConversion_nested_block_1467568()
        {
            string code =
                @"
            string error = " ";
            var mirror = thisTest.RunScriptSource(code, error);
            thisTest.Verify("myRangeExpressionResult", new object[] { 0.0, 1.5, 3.0 });
        }

        [Test]
        [Category("Type System")]
        public void TS0193_TypeConversion_nested_block_1467568()
        {
            string code =
                @"
            string error = " ";
            var mirror = thisTest.RunScriptSource(code, error);
            thisTest.VerifyRuntimeWarningCount(2);
            thisTest.Verify("myRangeExpressionResult", new object[] { 0, 1, 2 });
        }

        [Test]
        [Category("Type System")]
        public void TS0194_TypeConversion_nested_block_1467568()
        {
            string code =
                @"
            string error = " ";
            var mirror = thisTest.RunScriptSource(code, error);
            thisTest.Verify("myRangeExpressionResult", new object[] { 0.0, 0.5, 1.0 });
        }

        [Test]
        [Category("Type System")]
        public void TS0195_TypeConversion_nested_block_1467568()
        {
            string code =
                @"
            string error = " ";
            var mirror = thisTest.RunScriptSource(code, error);
            thisTest.Verify("t1", 2.000000);
            thisTest.Verify("t2", new object[] { 0.0000000, 1.500000, 3.000000 });
        }

        [Test]
        [Category("Type System")]
        public void TS0196_TypeConversion_nested_block_1467568()
        {
            string code =
                @"
            string error = " ";
            var mirror = thisTest.RunScriptSource(code, error);
            thisTest.Verify("t1", 2.000000);
            thisTest.Verify("t2", new object[] { 0.0000000, 1.500000, 3.000000 });
        }
    }
}
