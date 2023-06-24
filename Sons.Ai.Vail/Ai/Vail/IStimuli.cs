using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail
{
	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000082")]
	public interface IStimuli
	{
		// Token: 0x0600058B RID: 1419
		[Token(Token = "0x600058B")]
		bool IsValid();

		// Token: 0x0600058C RID: 1420
		[Token(Token = "0x600058C")]
		bool Validate(VailActor vailActor);

		// Token: 0x0600058D RID: 1421
		[Token(Token = "0x600058D")]
		string GetLog();

		// Token: 0x0600058E RID: 1422 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x2B295C0", Offset = "0x2B27BC0", VA = "0x182B295C0")]
		public static string Log(IStimuli stimuli)
		{
			return null;
		}

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x06000590 RID: 1424
		[Token(Token = "0x2000083")]
		public delegate bool FilterDelegate(VailActor actor, IStimuli a);
	}
}
