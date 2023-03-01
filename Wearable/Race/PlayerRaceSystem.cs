using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Sons.Wearable.Race
{
	// Token: 0x020005B2 RID: 1458
	[Token(Token = "0x20005B2")]
	[AddComponentMenu("Sons/Wearable/PlayerRace/PlayerRaceSystem")]
	public class PlayerRaceSystem : MonoBehaviour
	{
		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x0000AF98 File Offset: 0x00009198
		[Token(Token = "0x1700050B")]
		public PlayerRace.Race CurrentRace
		{
			[Token(Token = "0x6002572")]
			[Address(RVA = "0x589ED0", Offset = "0x588ED0", VA = "0x180589ED0")]
			get
			{
				return PlayerRace.Race.White;
			}
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002573")]
		[Address(RVA = "0x2D8AD90", Offset = "0x2D89D90", VA = "0x182D8AD90")]
		private PlayerRace GetRaceData()
		{
			return null;
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002574")]
		[Address(RVA = "0x2D8B680", Offset = "0x2D8A680", VA = "0x182D8B680")]
		public void SwitchToThirdPerson()
		{
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002575")]
		[Address(RVA = "0x2D8B670", Offset = "0x2D8A670", VA = "0x182D8B670")]
		public void SwitchToFirstPerson()
		{
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x0000AFB0 File Offset: 0x000091B0
		[Token(Token = "0x6002576")]
		[Address(RVA = "0x2D8AF40", Offset = "0x2D89F40", VA = "0x182D8AF40")]
		private bool IsLocalPlayer()
		{
			return default(bool);
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002577")]
		[Address(RVA = "0x2D8AD50", Offset = "0x2D89D50", VA = "0x182D8AD50")]
		public GameObject GetLeftArm()
		{
			return null;
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002578")]
		[Address(RVA = "0x2D8AEF0", Offset = "0x2D89EF0", VA = "0x182D8AEF0")]
		public GameObject GetRightArm()
		{
			return null;
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002579")]
		[Address(RVA = "0x2D8AC80", Offset = "0x2D89C80", VA = "0x182D8AC80")]
		public GameObject GetHead()
		{
			return null;
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x0600257A RID: 9594 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600257B RID: 9595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000016")]
		public event Action<PlayerRace.Race> OnRaceChanged
		{
			[Token(Token = "0x600257A")]
			[Address(RVA = "0x2D8B710", Offset = "0x2D8A710", VA = "0x182D8B710")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600257B")]
			[Address(RVA = "0x2D8B7C0", Offset = "0x2D8A7C0", VA = "0x182D8B7C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x0000AFC8 File Offset: 0x000091C8
		[Token(Token = "0x600257C")]
		[Address(RVA = "0x2D8ADE0", Offset = "0x2D89DE0", VA = "0x182D8ADE0")]
		public PlayerRace.Race GetRandomRace()
		{
			return PlayerRace.Race.White;
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257D")]
		[Address(RVA = "0x2D8B1A0", Offset = "0x2D8A1A0", VA = "0x182D8B1A0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257E")]
		[Address(RVA = "0x2D8ABF0", Offset = "0x2D89BF0", VA = "0x182D8ABF0")]
		public void ApplyRace(PlayerRace.Race race)
		{
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257F")]
		[Address(RVA = "0x2D8AFD0", Offset = "0x2D89FD0", VA = "0x182D8AFD0")]
		private void LoadRenderable(AssetReference assetReference)
		{
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002580")]
		[Address(RVA = "0x2D8B1B0", Offset = "0x2D8A1B0", VA = "0x182D8B1B0")]
		private void OnLoadDone(AsyncOperationHandle<GameObject> handle, AssetReference assetReference)
		{
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002581")]
		[Address(RVA = "0x2D8A900", Offset = "0x2D89900", VA = "0x182D8A900")]
		private void ApplyModel(AsyncOperationHandle<GameObject> handle, AssetReference assetReference)
		{
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002582")]
		[Address(RVA = "0x2D8B2B0", Offset = "0x2D8A2B0", VA = "0x182D8B2B0")]
		private void RetargetBonesToPlayer(Transform model)
		{
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002583")]
		[Address(RVA = "0x2D8B590", Offset = "0x2D8A590", VA = "0x182D8B590")]
		private void SetShadowCastingMode(ShadowCastingMode mode)
		{
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002584")]
		[Address(RVA = "0x2D8B570", Offset = "0x2D8A570", VA = "0x182D8B570")]
		public void SetDebugThirdPerson(bool value)
		{
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002585")]
		[Address(RVA = "0x2D8B690", Offset = "0x2D8A690", VA = "0x182D8B690")]
		public PlayerRaceSystem()
		{
		}

		// Token: 0x040021EB RID: 8683
		[Token(Token = "0x40021EB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<PlayerRace> _races;

		// Token: 0x040021EC RID: 8684
		[Token(Token = "0x40021EC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PlayerRace.Race _race;

		// Token: 0x040021ED RID: 8685
		[Token(Token = "0x40021ED")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _animationRoot;

		// Token: 0x040021EE RID: 8686
		[Token(Token = "0x40021EE")]
		[FieldOffset(Offset = "0x38")]
		private GameObject _head;

		// Token: 0x040021EF RID: 8687
		[Token(Token = "0x40021EF")]
		[FieldOffset(Offset = "0x40")]
		private GameObject _arms;

		// Token: 0x040021F0 RID: 8688
		[Token(Token = "0x40021F0")]
		[FieldOffset(Offset = "0x48")]
		private int _modelCountToApply;

		// Token: 0x040021F1 RID: 8689
		[Token(Token = "0x40021F1")]
		[FieldOffset(Offset = "0x4C")]
		private bool _debugThirdPerson;

		// Token: 0x040021F3 RID: 8691
		[Token(Token = "0x40021F3")]
		[FieldOffset(Offset = "0x0")]
		private static Random _random;
	}
}
