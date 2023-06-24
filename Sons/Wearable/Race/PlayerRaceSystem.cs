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
	// Token: 0x020005C2 RID: 1474
	[Token(Token = "0x20005C2")]
	[AddComponentMenu("Sons/Wearable/PlayerRace/PlayerRaceSystem")]
	public class PlayerRaceSystem : MonoBehaviour
	{
		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06002671 RID: 9841 RVA: 0x0000B658 File Offset: 0x00009858
		[Token(Token = "0x1700051F")]
		public PlayerRace.Race CurrentRace
		{
			[Token(Token = "0x6002671")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			get
			{
				return PlayerRace.Race.White;
			}
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002672")]
		[Address(RVA = "0x33AC1D0", Offset = "0x33AA7D0", VA = "0x1833AC1D0")]
		private PlayerRace GetRaceData()
		{
			return null;
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002673")]
		[Address(RVA = "0x33AC240", Offset = "0x33AA840", VA = "0x1833AC240")]
		public void SwitchToThirdPerson()
		{
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002674")]
		[Address(RVA = "0x33AC250", Offset = "0x33AA850", VA = "0x1833AC250")]
		public void SwitchToFirstPerson()
		{
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x0000B670 File Offset: 0x00009870
		[Token(Token = "0x6002675")]
		[Address(RVA = "0x33AC260", Offset = "0x33AA860", VA = "0x1833AC260")]
		private bool IsLocalPlayer()
		{
			return default(bool);
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002676")]
		[Address(RVA = "0x33AC3B0", Offset = "0x33AA9B0", VA = "0x1833AC3B0")]
		public GameObject GetLeftArm()
		{
			return null;
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002677")]
		[Address(RVA = "0x33AC4B0", Offset = "0x33AAAB0", VA = "0x1833AC4B0")]
		public GameObject GetRightArm()
		{
			return null;
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002678")]
		[Address(RVA = "0x33AC5B0", Offset = "0x33AABB0", VA = "0x1833AC5B0")]
		public GameObject GetHead()
		{
			return null;
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06002679 RID: 9849 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600267A RID: 9850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000019")]
		public event Action<PlayerRace.Race> OnRaceChanged
		{
			[Token(Token = "0x6002679")]
			[Address(RVA = "0x33AC830", Offset = "0x33AAE30", VA = "0x1833AC830")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600267A")]
			[Address(RVA = "0x33AC9A0", Offset = "0x33AAFA0", VA = "0x1833AC9A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x0000B688 File Offset: 0x00009888
		[Token(Token = "0x600267B")]
		[Address(RVA = "0x33ACB10", Offset = "0x33AB110", VA = "0x1833ACB10")]
		public static PlayerRace.Race GetRandomRace()
		{
			return PlayerRace.Race.White;
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267C")]
		[Address(RVA = "0x33ACCA0", Offset = "0x33AB2A0", VA = "0x1833ACCA0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267D")]
		[Address(RVA = "0x33ACCB0", Offset = "0x33AB2B0", VA = "0x1833ACCB0")]
		public void ApplyRace(PlayerRace.Race race)
		{
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267E")]
		[Address(RVA = "0x33ACD50", Offset = "0x33AB350", VA = "0x1833ACD50")]
		private void LoadRenderable(AssetReference assetReference)
		{
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267F")]
		[Address(RVA = "0x33AD180", Offset = "0x33AB780", VA = "0x1833AD180")]
		private void OnLoadDone(AsyncOperationHandle<GameObject> handle, AssetReference assetReference)
		{
		}

		// Token: 0x06002680 RID: 9856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002680")]
		[Address(RVA = "0x33AD2F0", Offset = "0x33AB8F0", VA = "0x1833AD2F0")]
		private void ApplyModel(Transform addressableObjectTransform, AssetReference assetReference, PlayerRace raceData)
		{
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002681")]
		[Address(RVA = "0x33AD7D0", Offset = "0x33ABDD0", VA = "0x1833AD7D0")]
		private void SetShadowCastingMode(ShadowCastingMode mode)
		{
		}

		// Token: 0x06002682 RID: 9858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002682")]
		[Address(RVA = "0x33AD930", Offset = "0x33ABF30", VA = "0x1833AD930")]
		public void SetDebugThirdPerson(bool value)
		{
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002683")]
		[Address(RVA = "0x33AD950", Offset = "0x33ABF50", VA = "0x1833AD950")]
		public void HideArms(bool value)
		{
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002684")]
		[Address(RVA = "0x33ADAC0", Offset = "0x33AC0C0", VA = "0x1833ADAC0")]
		public PlayerRaceSystem()
		{
		}

		// Token: 0x040022BF RID: 8895
		[Token(Token = "0x40022BF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<PlayerRace> _races;

		// Token: 0x040022C0 RID: 8896
		[Token(Token = "0x40022C0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PlayerRace.Race _race;

		// Token: 0x040022C1 RID: 8897
		[Token(Token = "0x40022C1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _animationRoot;

		// Token: 0x040022C2 RID: 8898
		[Token(Token = "0x40022C2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _isRobbyPlayer;

		// Token: 0x040022C3 RID: 8899
		[Token(Token = "0x40022C3")]
		[FieldOffset(Offset = "0x40")]
		private GameObject _head;

		// Token: 0x040022C4 RID: 8900
		[Token(Token = "0x40022C4")]
		[FieldOffset(Offset = "0x48")]
		private GameObject _arms;

		// Token: 0x040022C5 RID: 8901
		[Token(Token = "0x40022C5")]
		[FieldOffset(Offset = "0x50")]
		private int _modelCountToApply;

		// Token: 0x040022C6 RID: 8902
		[Token(Token = "0x40022C6")]
		[FieldOffset(Offset = "0x54")]
		private bool _debugThirdPerson;

		// Token: 0x040022C8 RID: 8904
		[Token(Token = "0x40022C8")]
		[FieldOffset(Offset = "0x0")]
		private static System.Random _random;
	}
}
