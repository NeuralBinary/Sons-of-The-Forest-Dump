using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gui
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public abstract class Carousel<T> : MonoBehaviour where T : MonoBehaviour
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		internal event Action<int, T, float> _optionDisplayVisibilityUpdate
		{
			[Token(Token = "0x600002B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600002C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		internal event Action<int, T, float> _optionVisibilityUpdate
		{
			[Token(Token = "0x600002D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600002E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x600002F")]
		public int GetSelectedIndex()
		{
			return 0;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x6000030")]
		public int GetSelectedOptionId()
		{
			return 0;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x6000031")]
		public int GetOptionCount()
		{
			return 0;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000032")]
		protected IReadOnlyList<T> GetDisplayList()
		{
			return null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000033")]
		protected IReadOnlyList<T> GetOptionsList()
		{
			return null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		internal virtual void Start()
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000035")]
		private void OnEnable()
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000036")]
		private void OnValidate()
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000037")]
		private void Update()
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		private void ForcedUpdate()
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		private void UpdateOptionVisibility(float currentScroll)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003A")]
		private void UpdateDisplayOptionVisibility(float currentScroll)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		private void UpdateVisibility(float wrappedScroll, List<T> options, Action<int, T, float> targetMethod)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003C")]
		public void Clear()
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003D")]
		private void SetPadding(bool value)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003E")]
		private void ClearWraparoundOptions()
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003F")]
		private void UpdateWraparounds()
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000040")]
		private void UpdatePaddingSiblingIndex()
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x6000041")]
		private int GetWrappedInt(int i, int count)
		{
			return 0;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x6000042")]
		private float GetWrappedValue(float scroll)
		{
			return 0f;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000043")]
		private void UpdateScroll()
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000044")]
		private void CenterCurrent()
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		internal virtual void UpdateVisuals()
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		public void NextItem()
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		public void PreviousItem()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x6000048")]
		public bool TrySetCurrentOptionId(int optionId)
		{
			return default(bool);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		private void AddOptionButton()
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600004A")]
		public T AddOption()
		{
			return null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600004B")]
		public T AddOption(int newId, bool forceUpdate = true)
		{
			return null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		protected Carousel()
		{
		}

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x0")]
		[FormerlySerializedAs("_textOptionTemplate")]
		[SerializeField]
		private T _optionTemplate;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Transform _optionParent;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected int _currentTarget;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		internal CarouselDirection _direction;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[FormerlySerializedAs("_optionHeight")]
		protected float _optionSpacing;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float _lerpTime;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float _fadeDistanceFactor;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<T> _optionsList;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private GameObject _padLeft;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private GameObject _padRight;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<int> _optionIdList;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<T> _displayList;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x0")]
		private T _lastOption;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x0")]
		private T _firstOption;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x0")]
		private bool _dirty;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x0")]
		private float _currentScroll;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x0")]
		private float _lastScrollStart;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x0")]
		private float _startScrollTime;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _setBaseOffsetOnStart;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x0")]
		private float _baseOffset;
	}
}
