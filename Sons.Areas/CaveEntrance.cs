using System;
using System.Runtime.CompilerServices;
using Endnight.Utilities;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Areas
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[AddComponentMenu("Sons/World/Cave Entrance")]
	public class CaveEntrance : MonoBehaviour
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000001")]
		private event Action<AreaMask> _onCaveEnteredEvent
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x2D270E0", Offset = "0x2D256E0", VA = "0x182D270E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x2D27250", Offset = "0x2D25850", VA = "0x182D27250")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600001C RID: 28 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000002")]
		private event Action<AreaMask> _onCaveExitedEvent
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x2D273C0", Offset = "0x2D259C0", VA = "0x182D273C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x2D27530", Offset = "0x2D25B30", VA = "0x182D27530")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2D276A0", Offset = "0x2D25CA0", VA = "0x182D276A0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2D276B0", Offset = "0x2D25CB0", VA = "0x182D276B0")]
		private void SetupTrigger()
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2D278A0", Offset = "0x2D25EA0", VA = "0x182D278A0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2D27980", Offset = "0x2D25F80", VA = "0x182D27980")]
		private void OnDisable()
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2D27A60", Offset = "0x2D26060", VA = "0x182D27A60")]
		private void OnCaveExit(GameObject obj)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2D27A80", Offset = "0x2D26080", VA = "0x182D27A80")]
		private void OnCaveEnter(GameObject obj)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2D270E0", Offset = "0x2D256E0", VA = "0x182D270E0")]
		public void RegisterOnCaveEntered(Action<AreaMask> action)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2D273C0", Offset = "0x2D259C0", VA = "0x182D273C0")]
		public void RegisterOnCaveExited(Action<AreaMask> action)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2D27250", Offset = "0x2D25850", VA = "0x182D27250")]
		public void UnregisterOnCaveEntered(Action<AreaMask> action)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2D27530", Offset = "0x2D25B30", VA = "0x182D27530")]
		public void UnregisterOnCaveExited(Action<AreaMask> action)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2D27AA0", Offset = "0x2D260A0", VA = "0x182D27AA0")]
		public void TriggerEnter()
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2D27AF0", Offset = "0x2D260F0", VA = "0x182D27AF0")]
		public void TriggerExit()
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public CaveEntrance()
		{
		}

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("_caveId")]
		[FormerlySerializedAs("_caveFilter")]
		private AreaMask _areaId;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DirectionalTrigger _trigger;
	}
}
