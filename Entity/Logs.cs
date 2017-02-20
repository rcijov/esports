using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkBuddies.Entity
{
    /// <summary>
    /// CREATE TABLE `Logs` (
    ///`idLog` int(11) NOT NULL AUTO_INCREMENT,
    ///`device` varchar(10) NOT NULL,
    ///`date` varchar(10) NOT NULL,
    ///`idUser` int(11) NOT NULL,
    ///PRIMARY KEY(`idLog`) USING BTREE,
    ///KEY `FK_Logs_Users` (`idUser`),
    ///CONSTRAINT `FK_Logs_Users` FOREIGN KEY(`idUser`) REFERENCES `Users` (`idUser`) ON DELETE NO ACTION ON UPDATE NO ACTION
    ///) ENGINE=InnoDB DEFAULT CHARSET=latin1;
    /// </summary>
    class Logs
    {
        /// <summary>
        /// Primary key for log
        /// </summary>
        int idLog { get; set; }

        /// <summary>
        /// Type of device (andorid/ios/mac)
        /// </summary>
        String device { get; set; }

        /// <summary>
        /// Date of the log
        /// </summary>
        String date { get; set; }

        /// <summary>
        /// Foreign key of the user
        /// </summary>
        int idUser { get; set; }
    }
}
