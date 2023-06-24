using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000E8 RID: 232
	[Token(Token = "0x20000E8")]
	public interface IConstraintsBatchImpl
	{
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600044F RID: 1103
		[Token(Token = "0x17000085")]
		Oni.ConstraintType constraintType { [Token(Token = "0x600044F")] get; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000450 RID: 1104
		[Token(Token = "0x17000086")]
		IConstraints constraints { [Token(Token = "0x6000450")] get; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000452 RID: 1106
		// (set) Token: 0x06000451 RID: 1105
		[Token(Token = "0x17000087")]
		bool enabled { [Token(Token = "0x6000452")] get; [Token(Token = "0x6000451")] set; }

		// Token: 0x06000453 RID: 1107
		[Token(Token = "0x6000453")]
		void Destroy();

		// Token: 0x06000454 RID: 1108
		[Token(Token = "0x6000454")]
		void SetConstraintCount(int constraintCount);

		// Token: 0x06000455 RID: 1109
		[Token(Token = "0x6000455")]
		int GetConstraintCount();
	}
}
