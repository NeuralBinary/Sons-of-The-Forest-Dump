using System;
using System.Runtime.CompilerServices;
using System.Text;
using AOT;
using Il2CppDummyDll;
using Sons.Multiplayer.Gui;
using Steamworks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Sons.Multiplayer
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	public class SteamManager : MonoBehaviour
	{
		// Token: 0x06000234 RID: 564 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x30F0800", Offset = "0x30EEE00", VA = "0x1830F0800")]
		public static PlayerColors GetPlayerColors()
		{
			return null;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x30F0850", Offset = "0x30EEE50", VA = "0x1830F0850")]
		public static bool TryGetInstance(out SteamManager result)
		{
			return default(bool);
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x1700004C")]
		public static bool Initialized
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x30F09F0", Offset = "0x30EEFF0", VA = "0x1830F09F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x30F0B30", Offset = "0x30EF130", VA = "0x1830F0B30")]
		public static bool IsInitialized()
		{
			return default(bool);
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00002E08 File Offset: 0x00001008
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004D")]
		public bool InitializeFailed
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x9962C0", Offset = "0x9948C0", VA = "0x1809962C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x9962D0", Offset = "0x9948D0", VA = "0x1809962D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x30F0B40", Offset = "0x30EF140", VA = "0x1830F0B40")]
		public static bool Reset()
		{
			return default(bool);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x30F0D00", Offset = "0x30EF300", VA = "0x1830F0D00")]
		[MonoPInvokeCallback(typeof(SteamAPIWarningMessageHook_t))]
		private static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x30F0D50", Offset = "0x30EF350", VA = "0x1830F0D50")]
		private static void DumpEnvironmentVariables()
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x30F0DF0", Offset = "0x30EF3F0", VA = "0x1830F0DF0")]
		private void Awake()
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x30F1400", Offset = "0x30EFA00", VA = "0x1830F1400")]
		private void OnEnable()
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x30F1640", Offset = "0x30EFC40", VA = "0x1830F1640")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x30F18E0", Offset = "0x30EFEE0", VA = "0x1830F18E0")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x30F1920", Offset = "0x30EFF20", VA = "0x1830F1920")]
		private void Update()
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SteamManager()
		{
		}

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x0")]
		private static SteamManager _instance;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PlayerColors _playerColors;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("initialized")]
		private bool _initialized;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent _initializeEvent;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent _initializeFailedEvent;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x40")]
		private SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;
	}
}
