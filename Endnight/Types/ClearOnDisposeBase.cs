using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace Endnight.Types
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	public abstract class ClearOnDisposeBase : IDisposable
	{
		// Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026E")]
		[Address(RVA = "0xA90660", Offset = "0xA8EC60", VA = "0x180A90660", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		protected virtual void PreDispose()
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		protected virtual void PostDispose()
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000271")]
		[Address(RVA = "0xA90A80", Offset = "0xA8F080", VA = "0x180A90A80")]
		private static object GetDefaultValue(PropertyInfo eachInfo, ClearOnDisposeAttribute attribute)
		{
			return null;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000272")]
		[Address(RVA = "0xA90B10", Offset = "0xA8F110", VA = "0x180A90B10")]
		private static object GetDefaultValue(FieldInfo eachInfo, ClearOnDisposeAttribute attribute)
		{
			return null;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000273")]
		[Address(RVA = "0xA90BA0", Offset = "0xA8F1A0", VA = "0x180A90BA0")]
		private static MemberInfo[] GetClearOnDisposeMembers(Type type)
		{
			return null;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected ClearOnDisposeBase()
		{
		}

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, MemberInfo[]> ClearOnDisposeMembersCache;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x8")]
		private static object _defaultInstance;
	}
}
