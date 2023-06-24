using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sons.Multiplayer
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	public class MultiplayerCallbacks : SingletonBehaviour<MultiplayerCallbacks>
	{
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000160 RID: 352 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000008")]
		private static event Action _callbackOnTitle
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x30E5C60", Offset = "0x30E4260", VA = "0x1830E5C60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x30E5DB0", Offset = "0x30E43B0", VA = "0x1830E5DB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x30E5F00", Offset = "0x30E4500", VA = "0x1830E5F00")]
		private void OnEnable()
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x30E5F90", Offset = "0x30E4590", VA = "0x1830E5F90")]
		private void OnDisable()
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000164")]
		public static GameObject CreateGameObject<T>(string objectName) where T : Component
		{
			return null;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000165")]
		public static GameObject CreateGameObject<T>(string objectName, out T component) where T : Component
		{
			return null;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x30E6020", Offset = "0x30E4620", VA = "0x1830E6020")]
		public static void RegisterDestroyOnTitleObject(GameObject obj)
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x30E61C0", Offset = "0x30E47C0", VA = "0x1830E61C0")]
		public static void RegisterCallbackOnTitle(Action callback)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x30E6330", Offset = "0x30E4930", VA = "0x1830E6330")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x30E6700", Offset = "0x30E4D00", VA = "0x1830E6700")]
		public MultiplayerCallbacks()
		{
		}

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x0")]
		private static List<GameObject> _destroyOnTitleObjects;
	}
}
