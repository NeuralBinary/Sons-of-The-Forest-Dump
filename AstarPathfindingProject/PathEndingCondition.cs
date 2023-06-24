using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x020000F6 RID: 246
	[Token(Token = "0x20000F6")]
	public abstract class PathEndingCondition
	{
		// Token: 0x06000869 RID: 2153 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected PathEndingCondition()
		{
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x6DD310", Offset = "0x6DB910", VA = "0x1806DD310")]
		public PathEndingCondition(Path p)
		{
		}

		// Token: 0x0600086B RID: 2155
		[Token(Token = "0x600086B")]
		public abstract bool TargetFound(PathNode node);

		// Token: 0x040005B5 RID: 1461
		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0x10")]
		protected Path path;
	}
}
