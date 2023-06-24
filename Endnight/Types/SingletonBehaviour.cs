using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Types
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	[DefaultExecutionOrder(-1000)]
	public abstract class SingletonBehaviour<T> : SingletonBehaviourBase where T : MonoBehaviour
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600027B RID: 635 RVA: 0x000033A8 File Offset: 0x000015A8
		[Token(Token = "0x17000020")]
		protected static bool HasInstance
		{
			[Token(Token = "0x600027B")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600027C RID: 636 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x17000021")]
		protected bool IsInstance
		{
			[Token(Token = "0x600027C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600027D")]
		protected static T GetInstance()
		{
			return null;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x600027E")]
		public virtual bool GetDontDestroyOnLoad()
		{
			return default(bool);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x600027F")]
		public virtual bool HideDontDestroyOnLoadProperty()
		{
			return default(bool);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000280")]
		protected static void SafeInitializeInstance()
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000281")]
		protected static void RegisterWithList<Tl>(Tl targetItem, ref List<Tl> targetList)
		{
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000282")]
		protected static void UnregisterWithList<Tl>(Tl targetItem, ref List<Tl> targetList)
		{
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000283")]
		protected static void InitializeInstance()
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000284")]
		protected static T GetOrCreateInstance()
		{
			return null;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x6000285")]
		public static bool TryGetInstance(out T instance)
		{
			return default(bool);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x6000286")]
		public static bool TryGetInstanceLogError(out T instance)
		{
			return default(bool);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x6000287")]
		protected static bool TryGetOrCreateInstance(out T instance)
		{
			return default(bool);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000288")]
		public sealed override void Awake()
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000289")]
		protected virtual void PostAwake()
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028A")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028B")]
		protected virtual void PostOnDestroy()
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028C")]
		protected SingletonBehaviour()
		{
		}

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _dontDestroyOnLoad;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x0")]
		private static T _instance;
	}
}
