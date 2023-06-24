using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	internal interface IPathInternals
	{
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000487 RID: 1159
		[Token(Token = "0x170000DF")]
		PathHandler PathHandler { [Token(Token = "0x6000487")] get; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000488 RID: 1160
		// (set) Token: 0x06000489 RID: 1161
		[Token(Token = "0x170000E0")]
		bool Pooled { [Token(Token = "0x6000488")] get; [Token(Token = "0x6000489")] set; }

		// Token: 0x0600048A RID: 1162
		[Token(Token = "0x600048A")]
		void AdvanceState(PathState s);

		// Token: 0x0600048B RID: 1163
		[Token(Token = "0x600048B")]
		void OnEnterPool();

		// Token: 0x0600048C RID: 1164
		[Token(Token = "0x600048C")]
		void Reset();

		// Token: 0x0600048D RID: 1165
		[Token(Token = "0x600048D")]
		void ReturnPath();

		// Token: 0x0600048E RID: 1166
		[Token(Token = "0x600048E")]
		void PrepareBase(PathHandler handler);

		// Token: 0x0600048F RID: 1167
		[Token(Token = "0x600048F")]
		void Prepare();

		// Token: 0x06000490 RID: 1168
		[Token(Token = "0x6000490")]
		void Initialize();

		// Token: 0x06000491 RID: 1169
		[Token(Token = "0x6000491")]
		void Cleanup();

		// Token: 0x06000492 RID: 1170
		[Token(Token = "0x6000492")]
		void CalculateStep(long targetTick);

		// Token: 0x06000493 RID: 1171
		[Token(Token = "0x6000493")]
		string DebugString(PathLog logMode);
	}
}
