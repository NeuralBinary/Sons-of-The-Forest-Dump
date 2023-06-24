using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;

namespace Sons.Ai.Vail.StimuliQueries
{
	// Token: 0x02000124 RID: 292
	[Token(Token = "0x2000124")]
	public class StimuliQueryIgnore : StimuliQuery<IgnoreStimuli>
	{
		// Token: 0x06000AB3 RID: 2739 RVA: 0x00006D80 File Offset: 0x00004F80
		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x2B8F750", Offset = "0x2B8DD50", VA = "0x182B8F750", Slot = "6")]
		public override bool Evaluate(VailActor actor, out IStimuli result, float maxDistance)
		{
			return default(bool);
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x2B8F7B0", Offset = "0x2B8DDB0", VA = "0x182B8F7B0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x2B8F7E0", Offset = "0x2B8DDE0", VA = "0x182B8F7E0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x2B8F860", Offset = "0x2B8DE60", VA = "0x182B8F860", Slot = "7")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00006D98 File Offset: 0x00004F98
		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x2B8F890", Offset = "0x2B8DE90", VA = "0x182B8F890")]
		public static bool IsValidType(Type stimuliType)
		{
			return default(bool);
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x2B8F8D0", Offset = "0x2B8DED0", VA = "0x182B8F8D0")]
		protected StimuliQueryIgnore(Type targetType, IStimuliSortAction.SortValueDelegate sortAction, IStimuli.FilterDelegate filterAction)
		{
		}
	}
}
