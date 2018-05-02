﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Microsoft.Toolkit.Uwp.UI.Controls.Graph
{
    /// <summary>
    /// Defines the properties for the <see cref="ProfileCard"/> control.
    /// </summary>
    public partial class ProfileCard : Control
    {
        /// <summary>
        /// Identifies the <see cref="GraphAccessToken"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty GraphAccessTokenProperty = DependencyProperty.Register(
            nameof(GraphAccessToken),
            typeof(string),
            typeof(ProfileCard),
            new PropertyMetadata(string.Empty, OnGraphAccessTokenChanged)
        );

        /// <summary>
        /// Identifies the <see cref="UserId"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty UserIdProperty = DependencyProperty.Register(
            nameof(UserId),
            typeof(string),
            typeof(ProfileCard),
            new PropertyMetadata(string.Empty, OnUserIdPropertyChanged)
        );

        /// <summary>
        /// Identifies the <see cref="DisplayMode"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty DisplayModeProperty = DependencyProperty.Register(
            nameof(DisplayMode),
            typeof(ViewType),
            typeof(ProfileCard),
            new PropertyMetadata(ViewType.PictureOnly, null)
        );

        /// <summary>
        /// Identifies the <see cref="DefaultImage"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty DefaultImageProperty = DependencyProperty.Register(
            nameof(DefaultImage),
            typeof(BitmapImage),
            typeof(ProfileCard),
            new PropertyMetadata(null, OnDefaultImageChanged)
        );

        /// <summary>
        /// Identifies the <see cref="DefaultTitleText"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty DefaultTitleTextProperty = DependencyProperty.Register(
            nameof(DefaultTitleText),
            typeof(string),
            typeof(ProfileCard),
            new PropertyMetadata(string.Empty)
        );

        /// <summary>
        /// Identifies the <see cref="DefaultSecondaryMailText"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty DefaultSecondaryMailTextProperty = DependencyProperty.Register(
            nameof(DefaultSecondaryMailText),
            typeof(string),
            typeof(ProfileCard),
            new PropertyMetadata(string.Empty)
        );

        /// <summary>
        /// Identifies the <see cref="DefaultMailText"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty DefaultMailTextProperty = DependencyProperty.Register(
            nameof(DefaultMailText),
            typeof(string),
            typeof(ProfileCard),
            new PropertyMetadata(string.Empty)
        );

        internal static readonly DependencyProperty _titleProperty = DependencyProperty.Register(
            nameof(_title),
            typeof(string),
            typeof(ProfileCard),
            new PropertyMetadata(string.Empty)
        );

        internal static readonly DependencyProperty _secondaryMailProperty = DependencyProperty.Register(
            nameof(_secondaryMail),
            typeof(string),
            typeof(ProfileCard),
            new PropertyMetadata(string.Empty)
        );

        internal static readonly DependencyProperty _mailProperty = DependencyProperty.Register(
            nameof(_mail),
            typeof(string),
            typeof(ProfileCard),
            new PropertyMetadata(string.Empty)
        );

        internal static readonly DependencyProperty _userPhotoProperty = DependencyProperty.Register(
            nameof(_userPhoto),
            typeof(BitmapImage),
            typeof(ProfileCard),
            new PropertyMetadata(null)
        );

        /// <summary>
        /// Gets or sets graph access token.
        /// </summary>
        public string GraphAccessToken
        {
            get
            {
                return (string)GetValue(GraphAccessTokenProperty);
            }
            set
            {
                SetValue(GraphAccessTokenProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets user unique identifier.
        /// </summary>
        public string UserId
        {
            get
            {
                return (string)GetValue(UserIdProperty);
            }
            set
            {
                SetValue(UserIdProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the visual layout of the control. Default is PictureOnly. 
        /// </summary>
        public ViewType DisplayMode
        {
            get
            {
                return (ViewType)GetValue(DisplayModeProperty);
            }
            set
            {
                SetValue(DisplayModeProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the default image when no user is signed in.
        /// </summary>
        public BitmapImage DefaultImage
        {
            get
            {
                return (BitmapImage)GetValue(DefaultImageProperty);
            }
            set
            {
                SetValue(DefaultImageProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the default title text in LargeProfilePhotoLeft mode or LargeProfilePhotoRight mode when no user is signed in.
        /// </summary>
        public string DefaultTitleText
        {
            get
            {
                return (string)GetValue(DefaultTitleTextProperty);
            }
            set
            {
                SetValue(DefaultTitleTextProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the default secondary mail text in LargeProfilePhotoLeft mode or LargeProfilePhotoRight mode when no user is signed in.
        /// </summary>
        public string DefaultSecondaryMailText
        {
            get
            {
                return (string)GetValue(DefaultSecondaryMailTextProperty);
            }
            set
            {
                SetValue(DefaultSecondaryMailTextProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the default mail text in EmailOnly mode when no user is signed in.
        /// </summary>
        public string DefaultMailText
        {
            get
            {
                return (string)GetValue(DefaultMailTextProperty);
            }
            set
            {
                SetValue(DefaultMailTextProperty, value);
            }
        }

        internal string _title
        {
            get
            {
                return (string)GetValue(_titleProperty);
            }
            private set
            {
                SetValue(_titleProperty, value);
            }
        }

        internal string _secondaryMail
        {
            get
            {
                return (string)GetValue(_secondaryMailProperty);
            }
            private set
            {
                SetValue(_secondaryMailProperty, value);
            }
        }

        internal string _mail
        {
            get
            {
                return (string)GetValue(_mailProperty);
            }
            private set
            {
                SetValue(_mailProperty, value);
            }
        }

        internal BitmapImage _userPhoto
        {
            get
            {
                return (BitmapImage)GetValue(_userPhotoProperty);
            }
            private set
            {
                SetValue(_userPhotoProperty, value);
            }
        }
    }
}
