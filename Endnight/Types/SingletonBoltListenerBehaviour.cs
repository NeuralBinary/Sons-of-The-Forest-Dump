using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Types
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	public abstract class SingletonBoltListenerBehaviour<T> : GlobalEventListener where T : MonoBehaviour
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000294 RID: 660 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x17000022")]
		protected static bool HasInstance
		{
			[Token(Token = "0x6000294")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x17000023")]
		protected bool IsInstance
		{
			[Token(Token = "0x6000295")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000296")]
		protected static T GetInstance()
		{
			return null;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000297")]
		protected static T GetOrCreateInstance()
		{
			return null;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000034B0 File Offset: 0x000016B0
		[Token(Token = "0x6000298")]
		protected static bool TryGetInstance(out T instance)
		{
			return default(bool);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x6000299")]
		protected static bool TryGetOrCreateInstance(out T instance)
		{
			return default(bool);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029A")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029B")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029C")]
		protected SingletonBoltListenerBehaviour()
		{
		}

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x0")]
		private static T _instance;
	}
}
