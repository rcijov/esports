using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkBuddies.Entity
{
    /// <summary>
    /// CREATE TABLE `Settings` (
    ///`idSettings` int(11) NOT NULL AUTO_INCREMENT,
    ///`device` varchar(10) DEFAULT NULL,
    ///`nickName` varchar(10) DEFAULT NULL,
    ///`private` tinyint(1) DEFAULT NULL,
    ///PRIMARY KEY(`idSettings`) USING BTREE
    ///) ENGINE=InnoDB DEFAULT CHARSET=latin1;
    /// </summary>
    class Settings
    {
        /// <summary>
        /// Primary key for settings
        /// </summary>
        int idSettings { get; set; }

        /// <summary>
        /// Type of device android/ios/windows
        /// </summary>
        String device { get; set; }

        /// <summary>
        /// User nick name
        /// </summary>
        String nickName { get; set; }

        /// <summary>
        /// Boolean for privacy
        /// </summary>
        Boolean pprivate { get; set; }
    }
}
