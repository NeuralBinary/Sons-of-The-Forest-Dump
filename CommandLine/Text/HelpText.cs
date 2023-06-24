using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CommandLine.Core;
using CSharpx;
using Il2CppDummyDll;

namespace CommandLine.Text
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	public class HelpText
	{
		// Token: 0x06000308 RID: 776 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x998710", Offset = "0x996D10", VA = "0x180998710")]
		private ComparableOption ToComparableOption(Specification spec, int index)
		{
			return default(ComparableOption);
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000096")]
		public Comparison<ComparableOption> OptionComparison
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x998890", Offset = "0x996E90", VA = "0x180998890")]
		public HelpText()
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x998910", Offset = "0x996F10", VA = "0x180998910")]
		public HelpText(SentenceBuilder sentenceBuilder)
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x998970", Offset = "0x996F70", VA = "0x180998970")]
		public HelpText(string heading)
		{
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x998A00", Offset = "0x997000", VA = "0x180998A00")]
		public HelpText(SentenceBuilder sentenceBuilder, string heading)
		{
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x998A70", Offset = "0x997070", VA = "0x180998A70")]
		public HelpText(string heading, string copyright)
		{
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x998AF0", Offset = "0x9970F0", VA = "0x180998AF0")]
		public HelpText(SentenceBuilder sentenceBuilder, string heading, string copyright)
		{
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000312 RID: 786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000097")]
		public string Heading
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x998D90", Offset = "0x997390", VA = "0x180998D90")]
			set
			{
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000313 RID: 787 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000314 RID: 788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000098")]
		public string Copyright
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x998E40", Offset = "0x997440", VA = "0x180998E40")]
			set
			{
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00002F28 File Offset: 0x00001128
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000099")]
		public int MaximumDisplayWidth
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x65D100", Offset = "0x65B700", VA = "0x18065D100")]
			set
			{
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00002F40 File Offset: 0x00001140
		// (set) Token: 0x06000318 RID: 792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700009A")]
		public bool AddDashesToOption
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x992180", Offset = "0x990780", VA = "0x180992180")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x7C3310", Offset = "0x7C1910", VA = "0x1807C3310")]
			set
			{
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00002F58 File Offset: 0x00001158
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700009B")]
		public bool AdditionalNewLineAfterOption
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x993BD0", Offset = "0x9921D0", VA = "0x180993BD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x998EF0", Offset = "0x9974F0", VA = "0x180998EF0")]
			set
			{
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00002F70 File Offset: 0x00001170
		// (set) Token: 0x0600031C RID: 796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700009C")]
		public bool AddNewLineBetweenHelpSections
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x998F00", Offset = "0x997500", VA = "0x180998F00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x998F10", Offset = "0x997510", VA = "0x180998F10")]
			set
			{
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600031D RID: 797 RVA: 0x00002F88 File Offset: 0x00001188
		// (set) Token: 0x0600031E RID: 798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700009D")]
		public bool AddEnumValuesToHelpText
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x998F20", Offset = "0x997520", VA = "0x180998F20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x998F30", Offset = "0x997530", VA = "0x180998F30")]
			set
			{
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00002FA0 File Offset: 0x000011A0
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700009E")]
		public bool AutoHelp
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x998F40", Offset = "0x997540", VA = "0x180998F40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x998F50", Offset = "0x997550", VA = "0x180998F50")]
			set
			{
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00002FB8 File Offset: 0x000011B8
		// (set) Token: 0x06000322 RID: 802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700009F")]
		public bool AutoVersion
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x998F60", Offset = "0x997560", VA = "0x180998F60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x998F70", Offset = "0x997570", VA = "0x180998F70")]
			set
			{
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A0")]
		public SentenceBuilder SentenceBuilder
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000324")]
		public static HelpText AutoBuild<T>(ParserResult<T> parserResult, Func<HelpText, HelpText> onError, Func<Example, Example> onExample, bool verbsIndex = false, int maxDisplayWidth = 80)
		{
			return null;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000325")]
		public static HelpText AutoBuild<T>(ParserResult<T> parserResult, int maxDisplayWidth = 80)
		{
			return null;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000326")]
		public static HelpText AutoBuild<T>(ParserResult<T> parserResult, Func<HelpText, HelpText> onError, int maxDisplayWidth = 80)
		{
			return null;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000327")]
		public static HelpText DefaultParsingErrorsHandler<T>(ParserResult<T> parserResult, HelpText current)
		{
			return null;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x996D30", Offset = "0x995330", VA = "0x180996D30")]
		public static implicit operator string(HelpText info)
		{
			return null;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x998F80", Offset = "0x997580", VA = "0x180998F80")]
		public HelpText AddPreOptionsLine(string value)
		{
			return null;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x999000", Offset = "0x997600", VA = "0x180999000")]
		public HelpText AddPostOptionsLine(string value)
		{
			return null;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x999080", Offset = "0x997680", VA = "0x180999080")]
		public HelpText AddPreOptionsLines(IEnumerable<string> lines)
		{
			return null;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x999140", Offset = "0x997740", VA = "0x180999140")]
		public HelpText AddPostOptionsLines(IEnumerable<string> lines)
		{
			return null;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x999200", Offset = "0x997800", VA = "0x180999200")]
		public HelpText AddPreOptionsText(string text)
		{
			return null;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x999320", Offset = "0x997920", VA = "0x180999320")]
		public HelpText AddPostOptionsText(string text)
		{
			return null;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032F")]
		public HelpText AddOptions<T>(ParserResult<T> result)
		{
			return null;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x999440", Offset = "0x997A40", VA = "0x180999440")]
		public HelpText AddVerbs(params Type[] types)
		{
			return null;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000331")]
		public HelpText AddOptions<T>(int maximumLength, ParserResult<T> result)
		{
			return null;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x9995B0", Offset = "0x997BB0", VA = "0x1809995B0")]
		public HelpText AddVerbs(int maximumLength, params Type[] types)
		{
			return null;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000333")]
		public static string RenderParsingErrorsText<T>(ParserResult<T> parserResult, Func<Error, string> formatError, Func<IEnumerable<MutuallyExclusiveSetError>, string> formatMutuallyExclusiveSetErrors, int indent)
		{
			return null;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000334")]
		public static IEnumerable<string> RenderParsingErrorsTextAsLines<T>(ParserResult<T> parserResult, Func<Error, string> formatError, Func<IEnumerable<MutuallyExclusiveSetError>, string> formatMutuallyExclusiveSetErrors, int indent)
		{
			return null;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000335")]
		public static string RenderUsageText<T>(ParserResult<T> parserResult)
		{
			return null;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000336")]
		public static string RenderUsageText<T>(ParserResult<T> parserResult, Func<Example, Example> mapperFunc)
		{
			return null;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000337")]
		public static IEnumerable<string> RenderUsageTextAsLines<T>(ParserResult<T> parserResult, Func<Example, Example> mapperFunc)
		{
			return null;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x999730", Offset = "0x997D30", VA = "0x180999730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x999BB0", Offset = "0x9981B0", VA = "0x180999BB0")]
		internal static void AddLine(StringBuilder builder, string value, int maximumLength)
		{
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x999DE0", Offset = "0x9983E0", VA = "0x180999DE0")]
		private IEnumerable<Specification> GetSpecificationsFromType(Type type)
		{
			return null;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x99A0E0", Offset = "0x9986E0", VA = "0x18099A0E0")]
		private static Maybe<Tuple<UsageAttribute, IEnumerable<Example>>> GetUsageFromType(Type type)
		{
			return null;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x99A260", Offset = "0x998860", VA = "0x18099A260")]
		private IEnumerable<Specification> AdaptVerbsToSpecifications(IEnumerable<Type> types)
		{
			return null;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x99A490", Offset = "0x998A90", VA = "0x18099A490")]
		private HelpText AddOptionsImpl(IEnumerable<Specification> specifications, string requiredWord, string optionGroupWord, int maximumLength)
		{
			return null;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x99ACC0", Offset = "0x9992C0", VA = "0x18099ACC0")]
		private OptionSpecification MakeHelpEntry()
		{
			return null;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x99AD90", Offset = "0x999390", VA = "0x18099AD90")]
		private OptionSpecification MakeVersionEntry()
		{
			return null;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x99AE60", Offset = "0x999460", VA = "0x18099AE60")]
		private HelpText AddPreOptionsLine(string value, int maximumLength)
		{
			return null;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x99AEE0", Offset = "0x9994E0", VA = "0x18099AEE0")]
		private HelpText AddOption(string requiredWord, string optionGroupWord, int maxLength, Specification specification, int widthOfHelpText)
		{
			return null;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x99B720", Offset = "0x999D20", VA = "0x18099B720")]
		private string AddOptionName(int maxLength, OptionSpecification specification)
		{
			return null;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x99B970", Offset = "0x999F70", VA = "0x18099B970")]
		private string AddValueName(int maxLength, ValueSpecification specification)
		{
			return null;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x99BC50", Offset = "0x99A250", VA = "0x18099BC50")]
		private HelpText AddLine(StringBuilder builder, string value)
		{
			return null;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x99BCD0", Offset = "0x99A2D0", VA = "0x18099BCD0")]
		private int GetMaxLength(IEnumerable<Specification> specifications)
		{
			return 0;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x99BE00", Offset = "0x99A400", VA = "0x18099BE00")]
		private int GetMaxOptionLength(OptionSpecification spec)
		{
			return 0;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x99BEA0", Offset = "0x99A4A0", VA = "0x18099BEA0")]
		private int GetMaxValueLength(ValueSpecification spec)
		{
			return 0;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000348")]
		private static string FormatDefaultValue<T>(T value)
		{
			return null;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x99C080", Offset = "0x99A680", VA = "0x18099C080")]
		[CompilerGenerated]
		private string <ToString>g__NewLineIfNeededBefore|79_0(StringBuilder sb, ref HelpText.<>c__DisplayClass79_0 A_2)
		{
			return null;
		}

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x0")]
		public static Comparison<ComparableOption> RequiredThenAlphaComparison;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		private const int BuilderCapacity = 128;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		private const int DefaultMaximumLength = 80;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		private const int OptionToHelpTextSeparatorWidth = 4;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		private const int OptionPrefixWidth = 2;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		private const int TotalOptionPadding = 6;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x18")]
		private readonly StringBuilder preOptionsHelp;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x20")]
		private readonly StringBuilder postOptionsHelp;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x28")]
		private readonly SentenceBuilder sentenceBuilder;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x30")]
		private int maximumDisplayWidth;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x38")]
		private string heading;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x40")]
		private string copyright;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x48")]
		private bool additionalNewLineAfterOption;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x50")]
		private StringBuilder optionsHelp;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x58")]
		private bool addDashesToOption;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x59")]
		private bool addEnumValuesToHelpText;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x5A")]
		private bool autoHelp;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x5B")]
		private bool autoVersion;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x5C")]
		private bool addNewLineBetweenHelpSections;
	}
}
