using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Backtrace.Unity.Json;
using Il2CppDummyDll;
using UnityEngine;

namespace Backtrace.Unity.Model.JsonData
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	public class Annotations
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000062")]
		public static Dictionary<string, string> EnvironmentVariablesCache
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x756110", Offset = "0x754710", VA = "0x180756110")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x7561E0", Offset = "0x7547E0", VA = "0x1807561E0")]
			set
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000063")]
		public Dictionary<string, string> EnvironmentVariables
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x756110", Offset = "0x754710", VA = "0x180756110")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x756270", Offset = "0x754870", VA = "0x180756270")]
			set
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000064")]
		public Exception Exception
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x756300", Offset = "0x754900", VA = "0x180756300")]
		public Annotations(Exception exception, int gameObjectDepth)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x756360", Offset = "0x754960", VA = "0x180756360")]
		private static Dictionary<string, string> SetEnvironmentVariables()
		{
			return null;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x756660", Offset = "0x754C60", VA = "0x180756660")]
		public BacktraceJObject ToJson()
		{
			return null;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x756E00", Offset = "0x755400", VA = "0x180756E00")]
		private BacktraceJObject ConvertGameObject(GameObject gameObject, int depth = 0)
		{
			return null;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x757300", Offset = "0x755900", VA = "0x180757300")]
		private BacktraceJObject ConvertGameObject(Component gameObject, string parentName, int depth)
		{
			return null;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x757790", Offset = "0x755D90", VA = "0x180757790")]
		private BacktraceJObject GetJObject(GameObject gameObject, string parentName = "")
		{
			return null;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x758140", Offset = "0x756740", VA = "0x180758140")]
		private BacktraceJObject GetJObject(Component gameObject, string parentName = "")
		{
			return null;
		}

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x0")]
		internal static Dictionary<string, string> _environmentVariablesCache;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x8")]
		internal static bool VariablesLoaded;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x10")]
		private readonly int _gameObjectDepth;
	}
}
